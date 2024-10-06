using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scoring : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    private int score =0;
    //public int maxScore;

    // Start is called before the first frame update
    void Start()
    {
        //score = 0;
        
    }

    

    public void UpdateScore()
    {
        score = GameManger.Instance.Getscore();
        ScoreText.text = "Score " + score + "/5";
    }
    // Update is called once per frame
  
}
