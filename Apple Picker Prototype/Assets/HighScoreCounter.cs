using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScoreCounter : MonoBehaviour
{
    static public int score = 1000;
    public TextMeshProUGUI gt;
    
    void Awake()
    {
        // If the ApplePickerHighScore already exists, read it
        if( PlayerPrefs.HasKey( "ApplePickerHighScore" ) )
        {
            score = PlayerPrefs.GetInt("ApplePickerHighScore");
        }
        // Assign the high score to ApplePickerHighScore
        PlayerPrefs.SetInt("ApplePickerHighScore", score);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject highscore = GameObject.Find("HighScoreCounter");
        gt = highscore.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        gt.SetText(score.ToString());
        
        // Update ApplePickerHighScore in PlayerRefs if necessary
        if( score > PlayerPrefs.GetInt( "ApplePickerHighScore" ) )
        {
            PlayerPrefs.SetInt("ApplePickerHighScore", score);
        }
    }
}
