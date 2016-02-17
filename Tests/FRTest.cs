using Xunit;
using System;
// using System.Linq;
using System.Collections.Generic;
namespace  FinderReplacer
{
  public class FRTest
  {
    [Fact]
    public void ReturnUniverseForWorld()
    {
      string newFindReplace = FindReplace.FindAndReplace("Hello World","World","universe");
      Assert.Equal("Hello universe", newFindReplace);
    }
    [Fact]
    public void ReturnUniverseForLowerCaseWorld()
    {
      string newFindReplace = FindReplace.FindAndReplace("Hello World","world","universe");
      Assert.Equal("Hello universe", newFindReplace);
    }
  }
}
