using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace FinderReplacer
{
  public class FindReplace
  {
    public static string FindAndReplace (string sentence, string wordChoice, string replaceChoice)
    {
      string pattern = "(?i)"+wordChoice;
      Regex regex = new Regex(pattern);
      return regex.Replace(sentence, replaceChoice);
    }
  }
}
