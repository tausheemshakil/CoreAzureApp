using corewebapiazure.Controllers;
using Xunit;

namespace CoreWebApiAzure.Test;


public class UnitTest1
{
    ValuesController objcontroller=new ValuesController (); //This is Arrabge
     
    [Fact]  //here are 3 fact 1.arrage, 2. act 3.assert
    public void Test1()
    {
      var obj=objcontroller.Get(1);  //this is Act
      Assert.Equal("Tausheemshakil",obj);
    }
}