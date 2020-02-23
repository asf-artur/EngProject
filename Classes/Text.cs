using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EngProject.Properties;
using NUnit.Framework;

namespace EngProject.Classes
{
    class Text
    {
        public List<Word> WordsList;
        public string text;

        public Text()
        {
            WordsList = new List<Word>();
        }

        public void GetText()
        {
            var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            using (var streamReader = new StreamReader( dir + "\\Txt\\text.txt", encoding:Encoding.ASCII))
            {
                text = streamReader.ReadToEnd();
            }
        }
    }
}
