
﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;


namespace RobinSkaCrasha
{
    public class StringHelper
    {
        public StringHelper()
        {

        }
        public string GetWord(string text, int x, char seperator = ' ')
        {

            var arr = text.Split(seperator);

            return arr[x];
        }

        public string[] StringToList(string text, char seperator = ' ')
        {
            var textString = text.Split(seperator);

            textString.ToList();

            return textString;
        }

        public string RemoveWord(string text, string remove)
        {
            return string.Empty;
        }

        public string RemoveWordAt(string text, int pos)
        {
            return string.Empty;
        }

        public string InsertWordAfter(string text, string after, string add)
        {
            return string.Empty;
        }

        public string SwapWords(string text, int word1, int word2)
        {
            return string.Empty;
        }
    }
}