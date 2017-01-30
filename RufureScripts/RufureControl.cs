using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class RufureControl : MonoBehaviour {

    SerialPort sp = new SerialPort("COM3", 9600);
    public float displacementX;
    private Rigidbody RB;
    private SphereCollider RBColl;
    private Transform Details;
    private Vector2 objpos1;
    private Vector2 objpos2;
    private Vector2 deltavect;
    private int test;

    // Use this for initialization
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        Details = GetComponent<Transform>();
        RBColl = GetComponent<SphereCollider>();
        sp.Open();
        sp.ReadTimeout = 5;
        objpos1.x = objpos1.y = -1;
        objpos2.x = objpos2.y = -1;
    }

    void FixedUpdate()
    {
        Ray mainray;
        RaycastHit hit;
        if (sp.IsOpen)
        {
            string value = sp.ReadLine();
            string[] temp = value.Split(',');
            if ((temp[0] != "-2") && (temp[1] != "-2")) //Check if all values are recieved
            {
                if (((Mathf.RoundToInt(objpos1.x)) == -1) && ((Mathf.RoundToInt(objpos1.y)) == -1))
                { objpos1.x = float.Parse(temp[0]); objpos1.y = float.Parse(temp[1]); }
                else { objpos2.x = float.Parse(temp[0]); objpos2.y = float.Parse(temp[1]); }
            }
            else
            {
                if (((Mathf.RoundToInt(objpos1.x)) != -1) && ((Mathf.RoundToInt(objpos1.y)) != -1)
                      && ((Mathf.RoundToInt(objpos2.x)) != -1) && ((Mathf.RoundToInt(objpos2.y)) != -1))
                {
                    deltavect = objpos2 - objpos1;
                    RB.AddForce(deltavect.x * 0.5f, deltavect.y * 0.5f, 0, ForceMode.VelocityChange);
                    objpos1.x = objpos1.y = -1; objpos2.x = objpos2.y = -1;
                }

                else if (((Mathf.RoundToInt(objpos1.x)) != -1) && ((Mathf.RoundToInt(objpos1.y)) != -1)
                      && ((Mathf.RoundToInt(objpos2.x)) == -1) && ((Mathf.RoundToInt(objpos2.y)) == -1))
                { objpos1.x = objpos1.y = -1; objpos2.x = objpos2.y = -1; }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}




