using SigniSightModel;
using Xunit;

namespace XUnitTest;

public class UserTest
{
    [Fact]
    public bool UsernameValidData()
    {
        //Arrange
        User UserModel = new User();
        string valid = "";
        //Act 
        UserModel.Username = valid;
        //Assert
        Assert.NotNull(UserModel.Username);
        Assert.Equal(valid, UserModel.Username);
        return true;
    }

    [Fact]
    public bool PasswordValidData()
    {
        User UserModel = new User();
        string valid = "";
        //Act 
        UserModel.Password = valid;
        //Assert
        Assert.NotNull(UserModel.Password);
        Assert.Equal(valid, UserModel.Password);
        return true;    
    }
    [Fact]
    public void EmailValidData()
    {
        User UserModel = new User();
        string valid = "";
        UserModel.Email = valid;
        Assert.NotNull(UserModel.Email);
        Assert.Equal(valid, UserModel.Email);
    }
    [Fact]
    public void AccountTypeValidData()
    {
        User UserModel = new User();
        string valid = "";
        UserModel.AccountType = valid;
        Assert.NotNull(UserModel.AccountType);
        Assert.Equal(valid, UserModel.AccountType);
    }
    

}

