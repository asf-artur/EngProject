using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;

namespace EngProject.Classes
{
    public class TextClass
        : ITextClass
    {
        /// <summary>
        /// Список слов с типом Word
        /// </summary>
        public ObservableCollection<Word> WordsList;

        /// <summary>
        /// Текст одной строкой
        /// </summary>
        public string Text
        {
            get { return allText; }
        }

        private string allText;

        public TextClass()
        {
            WordsList = new ObservableCollection<Word>();
            WordsList.CollectionChanged += WordListAdd;
        }

        /// <summary>
        /// Для события при добавлении нового слова, для того, чтобы заполнить поле Id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void WordListAdd(object sender, NotifyCollectionChangedEventArgs e)
        {
            WordsList[WordsList.Count - 1].Id = WordsList.Count;
        }

        /// <summary>
        /// Загрузка текста
        /// </summary>
        public void LoadText()
        {
            using (var streamReader = new StreamReader("ResFolder\\short_text.txt", encoding: Encoding.Unicode))
            {
                allText = streamReader.ReadToEnd();
            }
        }

        /// <summary>
        /// Добавить перевод
        /// </summary>
        /// <param name="wordString"> Слово</param>
        /// <param name="translationString"> Перевод слова</param>
        /// <param name="paragraph">Номер параграфа</param>
        public void AddTranslation(string wordString, string translationString, int paragraph)
        {
            var word = WordsList.ToList().Find(c => c.Meaning == wordString);
            if (word == null)
            {
                word = new Word(paragraph, wordString);
                WordsList.Add(word);
            }
            word.Translations.Add(translationString);
        }

        /// <summary>
        /// Изменение текущего перевода слова
        /// </summary>
        /// <param name="wordString">Слово</param>
        /// <param name="translationString">Перевод слова</param>
        public void ChangeTranslation(string wordString, string translationString)
        {
            var word = WordsList.ToList().Find(c => c.Meaning == wordString);
            if (word != null)
            {
                var translation = translationString;
                word.Chosen = translation;
            }
        }

        public Word GetWord(string wordString)
        {
            return WordsList.FirstOrDefault(c => c.Meaning == wordString);
        }

        public string GetTranslation(string wordString)
        {
            var word = WordsList.FirstOrDefault(c => c.Meaning == wordString);
            if (word == null)
            {
                return "Нет перевода";
            }

            return word.Chosen;
        }
    }
}
