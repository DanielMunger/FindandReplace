using Xunit;
using System;
using System.Collections.Generic;
using FindReplaces.Objects;

namespace  FindReplaces
{
  public class FindReplaceTests
  {
    [Fact]
    public void FindTest_Find_true()
    {
      //Arrange
      FindReplace newFindReplace = new FindReplace("this car is purple", "is", "purple");
      //Act
      string expected = "thpurple car purple purple";
      string result = newFindReplace.FindandReplace();
      //Assert
      Assert.Equal(true, result == expected);
    }


  }
}
