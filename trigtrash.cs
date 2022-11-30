using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class trigtrash : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cube,cube1,cube2,cube3,cube4,cube5;
    public float counter=0;
    public Text countertext;
    public GameObject question;
     private void OnTriggerEnter(Collider other) 
     {
        if(other.CompareTag("cube"))
        {
            Destroy(cube);
            counter++;
            countertext.GetComponent<Text>().text = "" + counter;
        }
        if(other.CompareTag("cube1"))
        {
           Destroy(cube1);
            counter++;
            countertext.GetComponent<Text>().text = "" + counter;
        }
        if(other.CompareTag("cube2"))
        {
           Destroy(cube2);
            counter++;
            countertext.GetComponent<Text>().text = "" + counter;
        }
        if(other.CompareTag("cube3"))
        {
           Destroy(cube3);
            counter++;
            countertext.GetComponent<Text>().text = "" + counter;
        }
        if(other.CompareTag("cube4"))
        {
           Destroy(cube4);
            counter++;
            countertext.GetComponent<Text>().text = "" + counter;
        }
        if(other.CompareTag("cube5"))
        {
           Destroy(cube5);
            counter++;
            countertext.GetComponent<Text>().text = "" + counter;
        }
        if(counter==6)
        {
           question.SetActive(true);
            countertext.GetComponent<Text>().text = "" + counter;
        }
     }
     public void Continue()
     {
         SceneManager.LoadScene("activity13");
        
    }
     public void quit()
    {
       SceneManager.LoadScene("activity13");
    }

}
