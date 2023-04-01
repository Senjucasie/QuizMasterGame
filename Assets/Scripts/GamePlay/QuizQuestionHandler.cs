using QuizGame.Data;
using System.Collections.Generic;
using UnityEngine;

public class QuizQuestionHandler:MonoBehaviour
{
    [SerializeField] private QuestionDataSO _questionSO;

    private List<QuestionData> _questionData= new();

    private int _totalQuestion;

    public int TotalQuestion { get => _totalQuestion; 
        private set=>_totalQuestion= _questionData.Count; }

    private int _currentQuestionIndex = 0;
    private QuestionData _currentQuestionData;

    private void Start()
    {
        InitializeQuestion();
    }

    private void InitializeQuestion()
    {
        _questionData = _questionSO.QuestionList;
        _currentQuestionData = _questionData[0];
    }
    

    public QuestionData NextQuestion()
    {
        _currentQuestionData = _questionData[_currentQuestionIndex++];
        return _currentQuestionData;
    }

    public bool CheckAnswer( int choice)
    {
        if (_currentQuestionData.correctAnswerIndex == choice)
            return true;
        else
            return false;
    }

    public QuestionData GetCurrentQuestion() => _currentQuestionData;

    
    

    
}
