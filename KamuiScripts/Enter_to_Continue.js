#pragma strict

    public var canvas1: GameObject;
    public var canvas2: GameObject;

function Start () {

}

function Update()
    { if (Input.GetKeyDown(KeyCode.Return))
        {   canvas1.SetActive(false);
            canvas2.SetActive(true);
        }
	}
