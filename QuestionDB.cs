using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTests.ModelsDB
{
    internal class QuestionDB
    {
        public int Number { get; set; }
        public string Text { get; set; }
        public List<string> Variants { get; set; }
        public int BallsCorrect { get; set; }
        public int CorrectNum { get; set; }
    }
}
