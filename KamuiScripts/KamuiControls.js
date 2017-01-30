#pragma strict
import UnityEngine.UI;

public var OBJ:GameObject;
public var speed:float;
public var keys:int;
public var cnvs:GameObject;
public var esccnvs:GameObject;
public var pause:GameObject;
public var keysText: Text;
public var scoreText: Text;
public var minimap: GameObject;
public var door:GameObject;

private var score:int;
private var RB:Rigidbody;

function Start () {
RB=OBJ.GetComponent.<Rigidbody>();
keysText.text= "Keys remaining: "+keys.ToString();
score=0;scoreText.text= "Score: "+score.ToString();
}

function Update () {

if(Input.GetKeyUp(KeyCode.Escape))
   {if(pause.activeInHierarchy==true) {pause.SetActive(false);Time.timeScale=1;}
    else if (pause.activeInHierarchy==false) {pause.SetActive(true);Time.timeScale=0;}
   }

if(Input.GetKeyDown(KeyCode.M))
   {if(minimap.activeInHierarchy==true) minimap.SetActive(false);
    else if (minimap.activeInHierarchy==false) minimap.SetActive(true);
   }

if (Input.GetKey(KeyCode.UpArrow))
     {RB.velocity=Vector3(0,0,speed);
      return;} 
  else if (Input.GetKey(KeyCode.DownArrow))
     {RB.velocity=Vector3(0,0,-speed);
      return;}
  else if (Input.GetKey(KeyCode.RightArrow) )
     {RB.velocity=Vector3(speed,0,0);
      return;} 
  else if(Input.GetKey(KeyCode.LeftArrow) )
     {RB.velocity=Vector3(-speed,0,0);
      return;}
  else{RB.velocity=Vector3(0,0,0);}


}



function OnTriggerEnter(other : Collider)
{if(other.CompareTag("Points"))
 { other.gameObject.SetActive(false);
   score+=1;scoreText.text= "Score: "+score.ToString();}

   else if(other.CompareTag("Keys"))
    {other.tag="Untagged";keys-=1;
     keysText.text= "Keys remaining: "+keys.ToString();
      if(keys==0) 
       {Destroy(door);
        cnvs.SetActive(true); 
        Time.timeScale=0;}
    }

   else if(other.CompareTag("escape_panel"))
    {esccnvs.SetActive(true); 
      Time.timeScale=0;}
}

