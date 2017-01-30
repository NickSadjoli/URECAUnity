#pragma strict

function Start () {

}

function Update () {

}

function Resume(pause:GameObject)
  {Time.timeScale=1;pause.SetActive(false);}
