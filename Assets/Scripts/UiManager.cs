using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{

    private int Score = 0;
    public Text ScoreText;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpdateScore()
    {
        Score++;
        ScoreText.text = "Score : " + Score;
    }
}
