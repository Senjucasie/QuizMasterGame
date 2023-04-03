using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class AnswerButtonUI : MonoBehaviour
{
    private int _childIndex;
    [SerializeField] private TextMeshProUGUI _answerText;
    private void OnEnable()
    {
        SetChildIndex();
    }
    
    private void SetChildIndex()
    {
        _childIndex = transform.GetSiblingIndex();
    }

    private void UpdateAnswer(string[] answers)
    {
        _answerText.text = answers[_childIndex];
    }

    private void OnDisable()
    {
    
    }
}
