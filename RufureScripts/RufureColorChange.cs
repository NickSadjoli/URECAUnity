using UnityEngine;
using System.Collections;

public class RufureColorChange : MonoBehaviour {

    private Rigidbody RB;
    private Renderer Rend;
    // Use this for initialization
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        Rend = GetComponent<Renderer>();
        Rend.material.color = Color.green;
    }

    // Update is called once per frame
    void Update ()
    { if (Mathf.RoundToInt(RB.velocity.x)!=0 || (Mathf.RoundToInt(RB.velocity.y)) != 0)
            Rend.material.color = Color.yellow;
        else Rend.material.color = Color.green;
	}
}
