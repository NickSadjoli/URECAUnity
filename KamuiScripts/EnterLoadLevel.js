#pragma strict
import UnityEngine.SceneManagement;

public var level:int;
public var loadimage: GameObject;
public var pnl: GameObject;

function Start () {

}

function Update () {
if (Input.GetKeyDown(KeyCode.Return))
        {pnl.SetActive(false);
         loadimage.SetActive(true);
         SceneManager.LoadScene(level);}
}


