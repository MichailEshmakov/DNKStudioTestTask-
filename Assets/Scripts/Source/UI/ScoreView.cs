using TMPro;
using UnityEngine;

public class ScoreView : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private Score _score;

    private void OnEnable()
    {
        FitText();
        _score.Changed += OnScoreChanged;
    }

    private void OnDisable()
    {
        _score.Changed -= OnScoreChanged;
    }

    private void OnScoreChanged()
    {
        FitText();
    }

    private void FitText()
    {
        _text.text = _score.Value.ToString();
    }
}
