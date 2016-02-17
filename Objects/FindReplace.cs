using System;
// using System.Linq;
using System.Collections.Generic;

namespace FinderReplacer

{

//   //variables//
//
  public class FindReplace
  {


//construtor//
    public static string FindAndReplace (string sentence, string wordChoice, string replaceChoice)
    {

      return sentence.Replace(wordChoice, replaceChoice);
    }
  }
}
