using System;
using UnityEngine;
using TMPro;
using System.Collections.Generic;
public class combo : MonoBehaviour
{
    private List<string> bumperTags = new List<string>();
    public static event System.Action<int, int> OnScoreChange;
    List<int> scores = new List<int>();
    private int scoreMultiplier = 1;
    public TextMeshProUGUI ScoreText;
    private void Start()
    {
        BumperHit.onBumperHit += CheckForCombo;             //luisteren naar action event onBumperHit als game start
    }
    private void OnDisable()
    {
        BumperHit.onBumperHit -= CheckForCombo;             //stop met luisteren naar action event onBumperHit als scene herstart of game stopt
    }
    private void CheckForCombo(string tag, int bumperValue)
    {
        bumperTags.Add(tag);                                //tag toevoegen aan lijst
        if (bumperTags.Count > 1)                           //check of er meer dan 1 tag is
        {                                                   //check of de laatste 2 tags gelijk zijn
            if (bumperTags[bumperTags.Count - 2] == bumperTags[bumperTags.Count - 1])
            {
                scoreMultiplier++;                          //verhoog de multiplier
            }using UnityEngine;


public class Combo : MonoBehaviour
{
    public static event Action<int, int> OnScoreChange;

    private int comboCount = 0;

    public void RegisterHit()
    {
        comboCount++;

        int newMultiplier = Mathf.Clamp(comboCount, 1, 10);

        ScoreManager.Instance.SetMultiplier(newMultiplier);
    }

    public void ResetCombo()
    {
        comboCount = 0;
        ScoreManager.Instance.SetMultiplier(1);
    }
}
            else                                            //als ze niet gelijk zijn
            {
                scoreMultiplier = 1;                        //reset multiplier
                bumperTags.Clear();                         //leeg de lijst met tags
            }
        }                                                   //voeg score toe aan de ScoreManager
        ScoreManager.Instance.AddScore(bumperValue * scoreMultiplier);

        

        //print score en multiplier in de console
        Debug.Log($"Score: {ScoreManager.Instance.score} || Multiplier: {scoreMultiplier}X");
        ScoreText.text = "Multiplier: " + scoreMultiplier.ToString() + "X";
    }
    
}


