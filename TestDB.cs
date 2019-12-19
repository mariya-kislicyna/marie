using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AppTests.ModelsDB
{
    internal class TestDB
    {
        // Название теста
        public string Name { get; set; }
        // Информация по тесту
        public string Info { get; set; }
        // Длительность теста (в минутах)
        public int Duration { get; set; }  // 0 == без ограничения времени
        // Список вопросов этого теста
        public List<QuestionDB> Questions { get; set; }
        public List<CriteriaDB> Criteries { get; set; }
    }
}
