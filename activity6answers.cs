using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class activity6answers : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField SandInput;
    public InputField LoamInput;
    public InputField ClayInput;
    public InputField nameInput;
    public int score;
    public TMP_Text scoreText,remarksText;
    public Text nameText;
   
    public void checkanswers()
    {
       
    }
    public void inputname()
    {
       
    }
    public void clearall()
    {
        score = 0;
        nameText.text = "Name=?";
        remarksText.text = "remarks=?";

    }
    private void Awake()
    {
        
    }
    private void Update()
    {
        nameText.text = nameInput.text;
        if (SandInput.text == "holds very little water")
        {
            score += +1;
            
            scoreText.text = "" + score;
            
        }
        if (LoamInput.text == "holds some water but not too much")
        {
            score += +1;
            scoreText.text = "" + score;
        }
        if (ClayInput.text == "holds a lot of water")
        {
            score += +1;
            scoreText.text = "" + score;
        }
        if (score <= 0)
        {
            remarksText.text = "Below expecations";
        }
        if (score <= 1)
        {
            remarksText.text = "Below expecations";
        }
        if (score >= 2)
        {
            remarksText.text = "met expectations. well done";
        }
        if (score >= 3)
        {
            remarksText.text = "exceeded expectations. super";
            score = 3;
        }
       

    }
    private void Start()
    {
      
    }


}
