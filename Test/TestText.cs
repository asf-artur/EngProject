using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EngProject.Classes;
using NUnit.Framework;

namespace EngProject.Test
{
    class TestText
    {
        private Text _text;

        [SetUp]
        public void SetUp()
        {
            _text = new Text();
        }

        [Test]
        public void Проверка_загрузки()
        {
            _text.GetText();
        }
    }
}
