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
      FindReplace newFindReplace = new FindReplace("Hello World","world","universe");
      Assert.Equal("Hello universe", newFindReplace.ReturnString());
    }
  }
}
