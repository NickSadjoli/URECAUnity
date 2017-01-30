#pragma strict
import UnityEngine.SceneManagement;
import UnityEngine.UI;

public var loadimage: GameObject;
public var pnl:GameObject;

function Start () {

}

function Update () {

}

public function LoadThisLevel(level:int)
{loadimage.SetActive(true);
 SceneManager.LoadScene(level);
 if(level==2)
   Time.timeScale = 0;
 }

public function QUIT()
{Application.Quit();}