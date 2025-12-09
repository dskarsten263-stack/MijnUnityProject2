using UnityEngine;
using TMPro;

public class UIScoreBoard : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text multiplierText;

    private void OnEnable()
    {
        combo.OnScoreChange += UpdateUI;
    }

    private void OnDisable()
    {
        combo.OnScoreChange -= UpdateUI;
    }

    void UpdateUI(int score, int multiplier)
    {
        scoreText.text = "Score: " + score;
        multiplierText.text = "Multiplier: x" + multiplier;
    }
}
