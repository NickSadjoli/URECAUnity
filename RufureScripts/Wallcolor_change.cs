using UnityEngine;
using System.Collections;

public class Wallcolor_change : MonoBehaviour {
    private Renderer Rend;

	// Use this for initialization
	void Start () {
        Rend = GetComponent<Renderer>();
        Rend.material.color = Color.blue;
	}

    // Update is called once per frame
    void Update() {
    }
	void OnCollisionEnter(Collision col)
    {if (col.gameObject.name =="Rufure")
        { if (Rend.material.color == Color.blue)
                Rend.material.color = Color.red;
            else if (Rend.material.color == Color.red)
                Rend.material.color = Color.green;
            else if (Rend.material.color == Color.green)
                Rend.material.color = Color.yellow;
            else if (Rend.material.color == Color.yellow)
                Rend.material.color = Color.magenta;
            else if (Rend.material.color == Color.magenta)
                Rend.material.color = Color.blue;
        }

    }
}
