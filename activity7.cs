using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activity7 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hintUi;
    public GameObject EVAUI;
    public void enableeva()
    {
        EVAUI.SetActive(true);
    }
    public void enableUi()
    {
        hintUi.SetActive(true);
    }
    public void disableUi()
    {
        hintUi.SetActive(false);
        EVAUI.SetActive(false);
    }




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
