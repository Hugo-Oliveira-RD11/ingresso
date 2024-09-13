using Ingresso.Core.Data;
using Ingresso.Core.Models.Corporation;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Ingresso.Core.Infra;

public class CorpRepository : ICorpRepository
{
    private readonly ConnectionDbContext _context;
    public CorpRepository( ConnectionDbContext context )
    {
        _context = context;
    }
    public async Task<Corp> CreateCorp(Corp corp)
    {
        if (corp is null) return null;

        var verified = await _context.Corps.FindAsync(corp.Id) != null ? true : false;
        if(!verified) return null;
        
        _context.Add(corp);
        await _context.SaveChangesAsync();
        return corp;
    }

    public async Task<Corp> UpdateById(Guid corpId, Corp corp)
    {
        if (corp is null) return null;

        var oldCorp = await _context.Corps.FindAsync(corpId);
        
        if(oldCorp is null) return null;

            oldCorp.Id = corp.Id;
            oldCorp.email = corp.email;
            oldCorp.password = corp.password;
            oldCorp.CNPJ = corp.CNPJ;
            oldCorp.Name_Cinema = corp.Name_Cinema;

        await _context.SaveChangesAsync();
        return corp;
    }

    public async Task<Corp> DeleteById(Guid corpId)
    {
            if(Guid.Empty == corpId) return null;
            
            var corp = await _context.Corps.FindAsync(corpId);
            if(corp is null) return null;
            
            _context.Corps.Remove(corp);
            _context.SaveChanges();
            
            return corp;
    }

    public async Task<List<Corp>> SearchById(Guid corpId)
    {
        return _context.Corps.ToList();
    }
}