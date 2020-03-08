using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Resources;

namespace EngProject.Classes
{
    public class Word
    {
        public int Paragraph;

        /// <summary>
        /// Само слово
        /// </summary>
        public string Meaning;
        public ObservableCollection<string> Translations = new ObservableCollection<string>();
        public string Chosen;
        public int Id;

        public Word(int paragraph, string meaning)
        {
            Paragraph = paragraph;
            Meaning = meaning;
            Translations.CollectionChanged += TranslationAdded;
        }

        public void TranslationAdded(object sender, NotifyCollectionChangedEventArgs e)
        {
            Chosen = e.NewItems[0].ToString();
        }
    }
}
 