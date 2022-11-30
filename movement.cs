using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class movement : MonoBehaviour
{
    // Start is called before the first frame update
   // public FixedButton jump;
    public FixedTouchField touchField;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var fps = GetComponent<RigidbodyFirstPersonController>();
        fps.mouseLook.LookAxis = touchField.TouchDist;
    }
}
