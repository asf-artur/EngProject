using EngProject.Classes;
using NUnit.Framework;
using System;
using System.Collections.ObjectModel;

namespace EngProject.Test
{
    class TestText
    {
        private TextClass _textClass;

        [SetUp]
        public void SetUp()
        {
            _textClass = new TextClass();
        }

        [Test]
        public void Проверка_загрузки()
        {
            _textClass.LoadText();
        }

        [Test]
        public void Проверка_добавления_перевода()
        {
            var meaning = "meaning";
            var translation = "translation";
            _textClass.WordsList = new ObservableCollection<Word>() { new Word(1, meaning) };
            _textClass.AddTranslation(meaning, translation, 0);
            Assert.AreEqual(translation, _textClass.WordsList[0].Chosen);
        }

        [Test]
        public void Проверка_события_WordsList()
        {
            _textClass.WordsList.Add(new Word(1, String.Empty));
            Assert.AreEqual(_textClass.WordsList.Count, _textClass.WordsList[_textClass.WordsList.Count - 1].Id);
        }
    }
}
