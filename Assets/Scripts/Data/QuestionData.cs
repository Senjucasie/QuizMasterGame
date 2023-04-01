using System.Collections.Generic;
namespace QuizGame.Data
{
    [System.Serializable]
    public class QuestionData
    {
        public string _question = "Enter new question text here";
        public List<string> _answerOptions = new List<string>();
        public int correctAnswerIndex;
    }
}

