using System;
using System.Collections.Generic;

namespace FindReplaces.Objects
{
  public class FindReplace
  {
    public string UserSentence {get; set;}
    public string UserReplaceWord {get; set;}
    public string ReplacementWord {get; set;}

    public FindReplace(string UserSentence, string UserReplaceWord, string ReplacementWord)
    {
      this.UserSentence = UserSentence;
      this.UserReplaceWord = UserReplaceWord;
      this.ReplacementWord = ReplacementWord;
    }

    public string FindandReplace()
    {
      if(this.UserSentence.Contains(this.UserReplaceWord))
      {
        string result = this.UserSentence.Replace(this.UserReplaceWord, this.ReplacementWord);
        return result;
       }
      return "Does not contain that word.";
    }
  }
}
