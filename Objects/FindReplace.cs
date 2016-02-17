using System;
// using System.Linq;
using System.Collections.Generic;

namespace FinderReplacer

{

//   //variables//
//
  public class FindReplace
  {
    private string _sentence;
    private string _wordChoice;
    private string _replaceChoice;

//construtor//
    public FindReplace (string sentence, string wordChoice, string replaceChoice)
    {
      _sentence = sentence;
      _wordChoice = wordChoice;
      _replaceChoice = replaceChoice;
    }
    public string GetSentence()
    {
      return _sentence;
    }
    public string GetWordChoice()
    {
      return _wordChoice;
    }
    public string GetReplaceChoice()
    {
      return _replaceChoice;
    }
    public string ReturnString()
    {
      return "Hello universe";
    }
  }
}
