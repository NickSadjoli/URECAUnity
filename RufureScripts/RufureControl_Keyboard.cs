using UnityEngine;
using System.Collections;

public class RufureControl_Keyboard : MonoBehaviour
{

    private Rigidbody RB;
    private Renderer Rnd;
    public float kbspeed;
    // Use this for initialization
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        Rnd = GetComponent<Renderer>();
        Rnd.material.color = Color.cyan;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement;
        movement = new Vector3(moveHorizontal, moveVertical, 0.0f);

        RB.AddForce(movement * kbspeed, ForceMode.Impulse);

        if (Input.GetKey("escape"))
            Application.Quit();

    }
}