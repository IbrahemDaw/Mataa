

namespace Domain.AppUser;

public interface IAppUserRepo
{
    public Task<AppUserOutputModelSimple> Get(int Id);
    public Task<AppUserOutputModelSimple> Get();
}
