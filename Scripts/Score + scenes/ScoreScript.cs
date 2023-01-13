using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    public TMP_Text text;
    public int score = 0;
    
    // Update is called once per frame
    private void FixedUpdate()
    {
        ScoreCounter();

        GoToBoss();

        TextUpdate();

       
    }

    
    public void ScoreCounter()
    {
        score++;
    }
    public void TextUpdate()
    {
        text.text = "Score:" +  score.ToString();
        
    }
    public void GoToBoss()
    {
        if (score == 2000)
        {
            SceneManager.LoadScene("Boss");

        }
    }
   
}
