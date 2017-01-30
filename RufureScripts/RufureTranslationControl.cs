using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class RufureTranslationControl : MonoBehaviour {

    SerialPort sp = new SerialPort("COM4", 9600);
    public float displacementX;
    private Rigidbody RB;
    private SphereCollider RBColl;
    private Transform Details;
    private Vector3 objpos1;
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
    }

    void FixedUpdate()
    {
        Ray mainray;
        RaycastHit hit;
        if (sp.IsOpen)
        {
            string value = sp.ReadLine();
            string[] temp = value.Split(',');
            if (temp[0] != "-2" && temp[1] != "-2") //Check if all values are recieved
            {  objpos1.x = float.Parse(temp[0]); objpos1.y = float.Parse(temp[1]);
                     transform.position = new Vector3(objpos1.x, objpos1.y, 0f); 
                
            }
          
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
