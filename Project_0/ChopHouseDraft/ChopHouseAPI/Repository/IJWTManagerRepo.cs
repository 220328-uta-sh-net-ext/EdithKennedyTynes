using CHModel;

namespace ChopHouseAPI.Repository
{
    public interface IJWTManagerRepo
    {
        Token Authenticate(AdminUser aduser);
    }
}
