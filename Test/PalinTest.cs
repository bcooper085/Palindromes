using Xunit;

namespace Palin.Objects
{
  public class PalinTest
  {
    [Fact]
    public void ReverseString_TestIfInputisPalin_BoobIsBoob()
    {
      //Arrange
      Palins testObj = new Palins();

      //Act
      bool testBool = testObj.ReverseString("kkkk");

      //Assert
      Assert.Equal(true, testBool);
    }
  }
}
