using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MailSender.Lib.Services
{
    /// <summary>
    /// Вспомогательный класс для работы со строками
    /// </summary>
    public static class PasswordHelper
    {
        /// <summary>
        /// Символы, из которых может состоять пароль
        /// </summary>
        private static readonly List<char> Chars = (
            "1234567890-=!@#$%^&*()_+" +
            "qQwWeErRtTyYuUiIoOpP[{]}\\|" +
            "aAsSdDfFgGhHjJkKlL;:'\"" +
            "zZxXcCvVbBnNmM,<.>/?").ToList();

        /// <summary>
        /// Шифрование одного символа
        /// </summary>
        /// <param name="ch">символ</param>
        /// <param name="key">ключ</param>
        private static char EncodeChar(char ch, int key)
        {
            // если символа нет в списке допустимых символов, возвращаем его как есть
            if (!Chars.Contains(ch))
                return ch;

            // это позволит работать с любым значением ключа
            if (Math.Abs(key) >= Chars.Count)
                key %= Chars.Count;

            // положение нового символа в спске символов
            var index = Chars.IndexOf(ch) + key;

            // циклический переход через границы списка
            if (index >= Chars.Count)
                index -= Chars.Count;
            else if (index < 0)
                index += Chars.Count;

            Debug.WriteLine($"PasswordHelper.EncodeChar({ch}, {key}) => '{Chars[index]}' (0x{(int)Chars[index]:X})");

            return Chars[index];
        }

        /// <summary>
        /// Шифрует пароль
        /// </summary>
        /// <param name="text">открытый пароль</param>
        /// <param name="key">ключ</param>
        public static string Encode(this string text, int key) => new string(text.Select(ch => EncodeChar(ch, key)).ToArray());
        
        /// <summary>
        /// Расшифровывает пароль
        /// </summary>
        /// <param name="text">зашифрованный пароль</param>
        /// <param name="key">ключ</param>
        public static string Decode(this string text, int key) => Encode(text, -key);
    }
}
