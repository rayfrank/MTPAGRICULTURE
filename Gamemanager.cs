using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
public class Gamemanager : MonoBehaviour
{
    // Start is called before the first frame update
     
    
    public AudioSource welcome;
    void Start()
    {
        StartCoroutine(startsound());
       
      
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator startsound()
    {
        yield return new WaitForSeconds(1f);
        welcome.Play();
    }
}
