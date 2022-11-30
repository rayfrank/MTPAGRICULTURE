using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;
using TMPro;

public class openbook : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cover;
    public GameObject fadeinblack;
    private bool isopened;
    public GameObject act1;
    public GameObject act2;
    public GameObject act4;
    public GameObject video1;
    public GameObject act3;
    public GameObject clay;
    public GameObject correctclayscreen;
    public GameObject disablevideo1;
    public GameObject wrongclayscreen;
    public GameObject wrongsandscreen;
    public GameObject backdisable;
    public GameObject any;
    public GameObject pausemenu;
    public GameObject isSavedtext;
    public GameObject sandAndLoamUi;
    public GameObject helpui;
    public GameObject optionsui;
    public GameObject GotoUi;
    public GameObject UserUi;
    public GameObject glossary;
    public GameObject ControlsUi;
    public int act4marks = 0;
    public Text studentmarks,remarks,Name;
    public GameObject act4marksdisplay;
    public TMP_InputField marksname;
    public GameObject answers2;
    public GameObject act6ans;
    public void checkact6ans()
    {
        act6ans.SetActive(true);
    }
    public void Disablecheckact6ans()
    {
        act6ans.SetActive(false);
    }
    public void enableanswers2()
    {
        answers2.SetActive(true);
    }
    public void answersdisable()
    {
        answers2.SetActive(false);
    }
    public void openControls()
    {
        ControlsUi.SetActive(true);
    }
    public void OpenGlossary()
    {
        glossary.SetActive(true);
    }
    public void openGoto()
    {
        GotoUi.SetActive(true);
    }
    public void OpenOptions()
    {
        optionsui.SetActive(true);
    }
    public void OpenUserUi()
    {
        UserUi.SetActive(true);
    }
    public void BackOPtionsui()
    {
        optionsui.SetActive(false);
        GotoUi.SetActive(false);
        ControlsUi.SetActive(false);
    }



    public void Sandandloam()
    {
        sandAndLoamUi.SetActive(true);
    }
    public void help()
    {
        helpui.SetActive(true);
    }
    public void helpuideactivate()
    {
        helpui.SetActive(false);
        UserUi.SetActive(false);
        glossary.SetActive(false);
    }
    public void backpausemenu()
    {
        pausemenu.SetActive(false); // pause menu is deactivated
        isSavedtext.SetActive(false);
    }
    public void Save()

    {
        PlayerPrefs.SetInt("SceneSaved", SceneManager.GetActiveScene().buildIndex);
        isSavedtext.SetActive(true);
    }
    public void Load()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("SceneSaved"));
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void pause()
    {
        pausemenu.SetActive(true);
         

    }
    public void school()
    {
        SceneManager.LoadScene("school");
    }
    public void disableany()
    {
         any.SetActive(false);
        act4marksdisplay.SetActive(false);
    }
    public GameObject sheet;
    public void loadnextscene()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void quit()
    {
        Application.Quit();
    }
    public void openactivity5()
    {
        SceneManager.LoadScene("activity5");
    }
    public void openpreviousactivity()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }
    public void displayName()
    {
        Name.text = marksname.text;
    }
    public void correctclayscreenactivate()
    {
        correctclayscreen.SetActive(true);
        act4marks += +1;
        if (act4marks >= 2)
        {
            act4marks = 2;
          
        }
        if(act4marks<=1)
        {
            remarks.text = "remarks= met expectations.Good Job";
        }
        if(act4marks<=0)
        {
            remarks.text = "remarks= below expectations";
        }
        if (act4marks >= 2)
        {
            remarks.text = "remarks= exceeded expectations. Super!!";
        }

    }
    public void act4results()
    {
        act4marksdisplay.SetActive(true);
        studentmarks.GetComponent<Text>().text = "" + act4marks;
    }
    public void act4resultsclear()
    {
        studentmarks.GetComponent<Text>().text = "0";
        remarks.text = "remarks=";
        Name.text = "Name=";
    }
    public void wrongsandscreenactivate()
    {
        wrongsandscreen.SetActive(true);
    }
    public void wrongclayscreenactivate()
    {
        wrongclayscreen.SetActive(true);
    }
    public void wrongsandscreendeactivate()
    {
       wrongsandscreen.SetActive(false);
    }
    public void wrongclayscreendeactivate()
    {
         wrongclayscreen.SetActive(false);
    }
    public void correctclaydeactivate()
    {
       correctclayscreen.SetActive(false);
    }
    void Start()
    {
      
        isopened=false;
        
       

     
    }
    public void openyoutubevideo()
    {
        Application.OpenURL(" https://www.youtube.com/watch?v=O22reYtlfNU");
    }
    public void openyoutubevideo2()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=dpKuVh8xXXsL");
    }

    // Update is called once per frame
  public   void Update()
    {
          StartCoroutine(Openbook());
        
        Screen.sleepTimeout = SleepTimeout.NeverSleep;     
        
    }
    public void opencover()
    {
        SceneManager.LoadScene("Cover");
    }
    public void correct_clay()
    {
        clay.SetActive(true);
    }
    public void open()
    {
        cover.GetComponent<Animation>().Play("coveropen");
        isopened=true;
    }
    IEnumerator Openbook()
    {
      
       if(isopened==true)
       {
            yield return new WaitForSeconds(2f);
            fadeinblack.SetActive(true);
           fadeinblack.GetComponent<Animation>().Play("fadeinblack");
           yield return new WaitForSeconds(1.0f);
            SceneManager.LoadScene("activity1");
       }
      
    }
    public void Activityone()
   {
       act1.SetActive(true);
        act4marks += +1;
        if(act4marks>=2)
        {
            act4marks = 2;
        }
        if (act4marks <= 1)
        {
            remarks.text = "remarks= met expectations.Good Job";
        }
        if (act4marks <= 0)
        {
            remarks.text = "remarks= below expectations";
        }
        if (act4marks >= 2)
        {
            remarks.text = "remarks= exceeded expectations. Super!!";
        }
    }
   

    public void openacivity2()
    {
        SceneManager.LoadScene("activity2");
    }
    public void openprevious()
    {
        SceneManager.LoadScene("activity13");
    }
    public void back()
    {
          act1.SetActive(false);
        sandAndLoamUi.SetActive(false);
         
    }
    public void back2()
    {
        act2.SetActive(false);
    }
    public void openacivity3()
    {
        act2.SetActive(true);
    }
    public void opentivity3()
    {
        SceneManager.LoadScene("activity3");
    }
    public void playvideo1()
    {
       video1.SetActive(true);
       disablevideo1.SetActive(true);
        act2.SetActive(false);
    }
    public void back3()
    {
        video1.SetActive(false);
        act2.SetActive(true);
        act3.SetActive(false);
        backdisable.SetActive(false);
    }
    public void backdisabledany()
    {
        backdisable.SetActive(false);
    }
    public void openactivity3b()
    {
        act3.SetActive(true);
         disablevideo1.SetActive(true);
    }
    public void openactivity4()
    {
        SceneManager.LoadScene("activity4");
    }
    public void openactivity4questions()
    {
       act4.SetActive(true);
    }
    public void openletuslearnone()
    {

    }
    public void farmgame()
    {
        SceneManager.LoadScene("farmgame");
    }
    public void openlongsheet()
    {
         sheet.SetActive(true);
    }
    public void backlongsheet()
    {
        sheet.SetActive(false);
    }
    public void backtoactivity6()
    {
        SceneManager.LoadScene("activity6");
    }
    

    

}
