using CHDL;

namespace CHBL
{
    internal interface IUserOperations
    {
        void Add(CHDL.Admin admin);
        void Delete(CHDL.Admin admin);
        CHDL.Admin SearchUser(string ID);
        CHDL.Admin Update(CHDL.Admin Admin);
    }
}
