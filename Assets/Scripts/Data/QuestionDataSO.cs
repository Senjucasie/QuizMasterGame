using System.Collections.Generic;
using UnityEngine;

namespace  QuizGame.Data
{
    [CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
    public class QuestionDataSO : ScriptableObject
    {
        public List<QuestionData> QuestionList;
    }

}
