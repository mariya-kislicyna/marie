using AppTests.ModelsDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTests.ModelsGUI
{
    public class Question 
    {
        private int _number { get; set; }
        private string _text { get; set; }
        private List<string> _variants { get; set; }
        private int _ballsCorrect { get; set; }
        private int _correctNum { get; set; }
        private int? _answerNum;

        public int Number => _number;
        public string Text => _text;
        public List<string> Variants => _variants;

        public int AnswerNum => _answerNum != null ? _answerNum.Value : -1;
        public bool IsAnswer => _answerNum != null ? true : false;
        public bool IsCorrect => _answerNum == _correctNum ? true : false;
        public int Balls => IsAnswer && _answerNum == _correctNum ?
            _ballsCorrect : 0;

        public Question(int number, string text, List<string> variants,
            int ballsCorrect, int correctNum)
        {
            _number = number;
            _text = text;
            _variants = variants;
            _ballsCorrect = ballsCorrect;
            _correctNum = correctNum;
            _answerNum = null;
        }

        public bool Answer(int varNum)
        {
            _answerNum = varNum;
            return varNum == _correctNum;
        }

        public void ResetAnswer()
        {
            _answerNum = null;
        }
    }
}
