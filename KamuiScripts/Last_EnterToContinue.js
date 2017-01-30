#pragma strict

public var canvas1: GameObject;

function Start () {

}

function Update () {
if (Input.GetKeyDown(KeyCode.Return))
        {canvas1.SetActive(false);
         Time.timeScale=1;}
    
}