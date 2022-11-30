using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class activity9 : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource clap,aww;
    public GameObject correctA,correctB,correctC;
    public Button ButtonA1,ButtonA2,ButtonA3, 
    ButtonB1, ButtonB2, ButtonB3, 
    ButtonC1, ButtonC2, ButtonC3,Evaluate;
    public GameObject AnsweredA, AnsweredB, AnsweredC;
    public GameObject wrong;
    public int score;
    public TMP_Text scoreText,remarks,named;
    public TMP_InputField Name;
    public GameObject evaluate;
    public bool isPressed = false;
    public void Submit()
    {
        named.text=Name.text;
    }
    public void evaluateenable()
    {
        evaluate.SetActive(true);
    }


    public void gotcorrectA()
    {
        correctA.SetActive(true);
        clap.Play();
        score += +1;
        isPressed = true;
        ButtonA1.interactable = false;
        ButtonA2.interactable = false;
        ButtonA3.interactable = false;
        AnsweredA.SetActive(true);
        scoreText.text = "" + score;
    }
    public void gotcorrectB()
    {
        correctB.SetActive(true);
        clap.Play();
        score += +1;
        AnsweredB.SetActive(true);
        ButtonB1.interactable = false;
        ButtonB2.interactable = false;
        ButtonB3.interactable = false;
        scoreText.text = "" + score;
    }
    public void gotcorrectC()
    {
        AnsweredC.SetActive(true);
        correctC.SetActive(true);
        clap.Play();
        score += +1;
        ButtonC1.interactable = false;
        ButtonC2.interactable = false;
        ButtonC3.interactable = false;
        scoreText.text = "" + score;
    }
    public void failedA()
    {
        ButtonA1.interactable = false;
        ButtonA2.interactable = false;
        ButtonA3.interactable = false;
        AnsweredA.SetActive(true);
    }
    public void failedB()
    {
        ButtonB1.interactable = false;
        ButtonB2.interactable = false;
        ButtonB3.interactable = false;
        AnsweredB.SetActive(true);
    }
    public void failedC()
    {
        ButtonC1.interactable = false;
        ButtonC2.interactable = false;
        ButtonC3.interactable = false;
        AnsweredC.SetActive(true);
    }
    public void clearchoiceC()
    {
        ButtonC1.interactable = true;
        ButtonC2.interactable = true;
        ButtonC3.interactable = true;
        AnsweredA.SetActive(false);
        AnsweredB.SetActive(false);
        AnsweredC.SetActive(false);
        scoreText.text = "";
        named.text = "";
        remarks.text = "";


    }
    public void clearchoiceB()
    {
        ButtonB1.interactable = true;
        ButtonB2.interactable = true;
        ButtonB3.interactable = true;
    }
    public void clearchoiceA()
    {
        ButtonA1.interactable = true;
        ButtonA2.interactable = true;
        ButtonA3.interactable = true;
    }
    public void gotwrong()
    {
        wrong.SetActive(true);
        aww.Play();
    }
   
    public void disableui()
    {
        correctA.SetActive(false);
        correctB.SetActive(false);
        correctC.SetActive(false);
        wrong.SetActive(false);
        evaluate.SetActive(false);

    }
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(score<=1)
        {
            remarks.text = "Poor.Below Expectations";
            
        }
        if(score>=2)
        {
            remarks.text = "Good Job.Met Expectations";
        }
        if(score>=3)
        {
            remarks.text = "Super!!!!!.Above Expectations";
            
        }
        
    }
}
