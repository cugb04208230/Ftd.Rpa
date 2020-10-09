using Ftd.Rpa.BaseModel.Identity;

namespace Ftd.Rpa.HttpContext
{
    public interface ICurrentUser
    { 
        User User { get; }
    }
}
