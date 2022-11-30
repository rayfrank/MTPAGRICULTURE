using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermechanics : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Mechanisms();
    }
    public void Mechanisms()
    {
        if(Input.GetAxis("Vertical")>0 || Input.GetButton("Mouse Y"))
        {
            player.GetComponent<Animator>().SetBool("walk", true);
        }
        if (Input.GetAxis("Vertical") < 0  || Input.GetButton("Mouse Y"))
        {
            player.GetComponent<Animator>().SetBool("walk", true);
        }
        if (Input.GetAxis("Vertical")  == 0)
        {
            player.GetComponent<Animator>().SetBool("walk", false);
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            player.GetComponent<Animator>().SetBool("walk", true);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            player.GetComponent<Animator>().SetBool("walk", true);
        }
        if(Input.GetButton("Sprint") && Input.GetAxis("Vertical")>0)
        {
            player.GetComponent<Animator>().SetBool("run", true);
        }
        if (Input.GetButtonUp("Sprint"))
        {
            player.GetComponent<Animator>().SetBool("run", false);
        }
    }
}
