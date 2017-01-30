using UnityEngine;
using System.Collections;

public class RufureRotate : MonoBehaviour {

    public float rotspeed;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, rotspeed * Time.deltaTime, 0));	}
}
