using System;
using System.Collections.Generic;
using System.Text;

namespace AppTests
{
    static public class IDGenerator
    {
        static private int _testNumber = 1; // номера пользователей начинается с 1

        static public int GenerateTestID()
        {
            if (_testNumber == int.MaxValue) return 0;  // если не достигли максимума для int'а
            _testNumber++;  // увеличиваем номер пользователя
            return _testNumber; // возвращаем номер пользователя
        }
    }
}
