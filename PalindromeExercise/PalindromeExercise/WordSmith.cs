﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word) 
        {
            string forwards = "";
            string backwards = "";
            for(int i  = word.Length -  1; i >= 0; i--) 
            {
                backwards += word[i];
            }
            if(word == backwards) 
            {
                return true;
            }
            return false;
        }
    }
}
