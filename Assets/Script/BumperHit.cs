using UnityEngine;

public class BumperHit : MonoBehaviour
{
    public int points = 100;
    public Combo combo;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ScoreManager.Instance.AddScore(points);
        combo.RegisterHit();
    }
}
