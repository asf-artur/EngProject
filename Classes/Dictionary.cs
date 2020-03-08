using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EngProject.Classes;

namespace EngProject.Classes
{
    class Dictionary
    {
        public List<Word> WordsList;
        public Word Get (string s)
        {
            foreach (var s1 in WordsList)
            {
                if (s1.Meaning == s)
                    return s1;
            }
            return null;
        }
        public bool InDict (string s)
        {
            foreach (var i in WordsList)
            {
                if (i.Meaning == s)
                    return true;
            }
            return false;
           
        }
    }
}
