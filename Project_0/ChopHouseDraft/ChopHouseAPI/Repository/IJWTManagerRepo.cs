using CHModel;

namespace ChopHouseAPI.Repository
{
    public interface IJWTManagerRepo
    {
        Token Authenticate(User user);
    }
}
