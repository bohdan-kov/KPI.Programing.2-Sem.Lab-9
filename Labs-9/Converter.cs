using System;
using System.Text;

namespace Labs_9
{
    class Converter
    {
        public string _string { get; private set; }
        public Converter(string stringDate)
        {
            if (string.IsNullOrEmpty(stringDate))
            {
                throw new ArgumentNullException("Переданий об'єкт String не може бути пустим!");
            }
            _string = stringDate;
        }

        /// <summary>
        /// Завдання №5
        /// </summary>
        /// <returns></returns>
        public int BinaryStringToInt()
        {
            ValidateBinaryString();
            double result = 0;

            for (int i = _string.Length - 1; i >= 0; i--)
            {
                if (_string[i] == '1') 
                {
                    result += Math.Pow(2, i);
                };
                
            }
            return (int)result;
        }

        /// <summary>
        /// Завдання №21
        /// </summary>
        /// <returns></returns>
        public string TaskTwoMethod()
        {
            ValidateSetntence();
            string result = "";

            foreach (var elem  in _string.Split(' '))
            {

                if (IsWord(elem))
                {
                    foreach (var let in elem)
                    {
                        result += char.ToLower(let);
                    }
                    result += ' ';
                }
                else result += $" {elem} ";
            }
            // Удалить зайвий пробіл :D
            result = result.Substring(0, result.Length - 1);
            return result;
        }


        /// <summary>
        /// Система валiдацiя для завдання №1 перевiряє строку на наявнiсть недопустимих символiв
        /// У випадку знаходження викликає помилку
        /// 
        /// Логiка валiдацiї - White List (Бiлий список) система пропускає лише обранi символи,
        /// знаходження вiдбувається за iндексом в системi ASCII
        /// 
        /// Значення в системi ASCII крайнiх допустимих символiв
        /// White List:
        /// 1) Цифри: 0-9 [0 - 48, 1 - 49]

        /// </summary>
        /// <param name="String"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void ValidateBinaryString()
        {
            foreach (var el in _string)
            {
                int ascii = (int)el;
                if (!(ascii == 48 || ascii == 49))
                { 
                    throw new ArgumentException($"В реченнi знайдений недоступний символ: [{el}]");
                }
            }
            Console.WriteLine("\n\nПередане речення пройшло валiдацiю!\n\n");
        }
        
        /// <summary>
        /// Система валiдацiя для завдання №2 перевiряє строку на наявнiсть недопустимих символiв
        /// У випадку знаходження викликає помилку
        /// 
        /// Логiка валiдацiї - White List (Бiлий список) система пропускає лише обранi символи,
        /// знаходження вiдбувається за iндексом в системi ASCII
        /// 
        /// Значення в системi ASCII крайнiх допустимих символiв
        /// White List:
        /// 1) Лiтери: a-z [a - 97, z - 122]; A-Z [A - 65, Z - 90]
        /// 2) Цифри: 0-9 [0 - 48, 9 - 57]
        /// 3) Пробіл: [' ' - 32]
        /// 
        /// </summary>
        /// <param name="String"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void ValidateSetntence()
        {
            foreach (var el in _string)
            {
                int ascii = (int)el;
                if (!(ascii >= 97 && ascii <= 122 || ascii >= 65 && ascii <= 90 
                    || ascii >= 48 && ascii <= 57 || ascii == 32))
                {
                    throw new ArgumentException($"В реченнi знайдений недоступний символ: [{el}]");
                }
            }
            Console.WriteLine("\n\nПередане речення пройшло валiдацiю!\n\n");
        }

        public bool IsWord(string word)
        {

            foreach(var letter in word)
            {
                int letter_ascii = (int)letter;
                if (!(letter_ascii >= 97 && letter_ascii <= 122 || letter_ascii >= 65 && letter_ascii <= 90))
                {
                    return false;
                }
            }    
            return true;
        }
    }
}
