using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTests.ModelsGUI
{
    public class Test
    {
        public string Name { get; private set; }
        // Информация по тесту
        public string Info { get; private set; }
        // Длительность теста (в минутах)
        public int Duration { get; private set; }  // 0 == без ограничения времени
        // Список вопросов этого теста
        public List<Question> Questions { get; private set; }
        // Список критериев оценки для этого теста
        public List<Criteria> Criteries { get; private set; }

        public Test (string name, string info, int duration, 
            List<Question> questions, List<Criteria> criteries)
        {
            Name = name;
            Info = info;
            Duration = duration;
            Questions = questions;
            Criteries = criteries;
        }

        public Criteria GetResult(int ball)
        {
            return Criteries.OrderByDescending(t => t.Ball)
                .FirstOrDefault(t => t.Ball <= ball);               
        }

    }
}
