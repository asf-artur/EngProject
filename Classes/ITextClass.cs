﻿namespace EngProject.Classes
{
    public interface ITextClass
    {
        /// <summary>
        /// Загрузка текста из файла
        /// </summary>
        void LoadText();

        /// <summary>
        /// Изменение перевода
        /// </summary>
        /// <param name="wordString">Само слово</param>
        /// <param name="translationString">Перевод слова</param>
        void ChangeTranslation(string wordString, string translationString);

        /// <summary>
        /// Получить объект типа Word по его имени
        /// </summary>
        /// <param name="wordString">имя слова</param>
        /// <returns>Объект Word или null, если такого слова нет</returns>
        Word GetWord(string wordString);
    }
}
