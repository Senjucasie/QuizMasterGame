using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] private Slider _questionSlider;

    private void Awake()
    {
    _questionSlider = GetComponent<Slider>();
    }

    private void UpdateProgressBar(float questionnumber)
    {
        _questionSlider.value = questionnumber;
    }

    private void ResetProgressBar()
    {
        _questionSlider.value = 0;
    }
}
