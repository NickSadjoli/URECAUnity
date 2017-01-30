using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class RufureFlickControl : MonoBehaviour {

    SerialPort sp = new SerialPort("COM3", 9600);
    private Rigidbody RB;
    public float flickspeed;
	// Use this for initialization
	void Start () {
        RB = GetComponent<Rigidbody>();
        sp.Open();
        sp.ReadTimeout = 5;

	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {   if (sp.IsOpen)
        { string value = sp.ReadLine();
            if ((value != "-2")&&(Mathf.RoundToInt(RB.velocity.x)==0)&&(Mathf.RoundToInt(RB.velocity.y) == 0))  //Check if all values are recieved
            { if (int.Parse(value) == 0) RB.AddForce(-flickspeed, 0, 0, ForceMode.Impulse);
                else if (int.Parse(value) == 1) RB.AddForce(flickspeed, 0, 0, ForceMode.Impulse);
                else if (int.Parse(value) == 2) RB.AddForce(0,-flickspeed, 0, ForceMode.Impulse);
                else if (int.Parse(value) == 3) RB.AddForce(0,flickspeed, 0, ForceMode.Impulse);
            }
         }
        if (Input.GetKey("escape"))
            Application.Quit();
    }
}
