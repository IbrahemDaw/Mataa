
using Mataa.Data;
using Microsoft.EntityFrameworkCore;

namespace Domain.AppUser;

public class AppUserRepo : IAppUserRepo
{
    private readonly MataaDbContext _db ;
    public AppUserRepo(MataaDbContext mataaDbContext )
    {
        _db = mataaDbContext;
    }

    public Task<AppUserOutputModelSimple> Get(int Id)
    {
        throw new NotImplementedException();
    }

    public async Task<AppUserOutputModelSimple> Get()
    {
        return await _db.AppUsers.Select(x=> new AppUserOutputModelSimple
        {
            Name = x.Name
        }).FirstOrDefaultAsync();
    }
}
