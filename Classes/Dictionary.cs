using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EngProject.Classes;

namespace EngProject.Classes
{
    class Dictionary
    {
        public List<Word> WordsList;
        public Dictionary()
        {
            WordsList = new List<Word>();
            LoadFromProgram();
        }

        public Dictionary(List<Word> wordsList)
        {
            WordsList = wordsList;
        }

        public void LoadFromProgram()
        {
            WordsList.Add(
                new Word(0, "software")
                {
                    Translations = new ObservableCollection<string>()
                    {
                        "программное обеспечение",
                        "программный продукт",
                        "софт"
                    },
                    CurrentTranslation = "софт"
                });
            WordsList.Add(
                new Word(0, "code")
                {
                    Translations = new ObservableCollection<string>()
                    {
                        "код",
                        "кодекс",
                        "норма"
                    },
                    CurrentTranslation = "код"
                });
        }
        public Word GetWord (string s)
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
