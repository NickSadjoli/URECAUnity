#pragma strict

private var rend:Renderer;
private var panel:Collider;

function Start () {
rend=GetComponent.<Renderer>();
rend.material.color=Color.yellow;
}

function Update () {

}

function OnCollisionEnter(col:Collision)
    {if (col.gameObject.name =="Kamui") 
          {rend.material.color=Color.red;
           panel.enabled=false;}
     }