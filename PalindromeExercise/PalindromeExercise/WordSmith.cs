using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
  public class WordSmith
    {
        public bool isPalindrome(string word)
        {
            if(word==null || word.Length==0) return false;
          var orig= word.ToLower().ToCharArray();
            var reversed=word.ToCharArray().Reverse();
          return orig.SequenceEqual(reversed);
        }
    }
}
