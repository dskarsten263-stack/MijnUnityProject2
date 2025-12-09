using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public int score;
    public int multiplier = 1;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public void AddScore(int basePoints)
    {
        int finalPoints = basePoints * multiplier;
        score += finalPoints;

        // Stuur score + multiplier naar UI
        combo.OnScoreChange?.Invoke(score, multiplier);

        Debug.Log($"Score: {score} | Multiplier: x{multiplier}");
    }

    public void SetMultiplier(int newMultiplier)
    {
        multiplier = newMultiplier;
        combo.OnScoreChange?.Invoke(score, multiplier);
    }
}
