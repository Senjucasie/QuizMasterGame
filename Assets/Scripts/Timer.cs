using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float fillFraction;

    private bool _updateTimer = false;

    [SerializeField] private float _currentQuestionTime,_remainingTime;
    [SerializeField] private Image _timerImage;

    private const int _defaultFillValue = 1;

    void Update()
    {
        if (_updateTimer)
            UpdateTimer();
    }

    private void StopTimer() => _updateTimer = false;
    

    private void UpdateTimer()
    {
        _remainingTime -= Time.deltaTime;
        if(_remainingTime > 0)
        {
            fillFraction = _remainingTime / _currentQuestionTime;
            _timerImage.fillAmount = fillFraction;
        }
        else
        {
            StopTimer();
        }
       
    }

    private void StartTimer(float timeforquestion)
    {
        _currentQuestionTime = _remainingTime = timeforquestion;
        _timerImage.fillAmount = _defaultFillValue;
        _updateTimer = true;
    }


   
}
