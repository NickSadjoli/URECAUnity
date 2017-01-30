#pragma strict
import UnityEngine.UI;

public var player:GameObject;
public var camoption:Dropdown;

private var Offset:Vector3;

function Start () {

}

function FixedUpdate () {
Offset=player.transform.position-transform.position;
Debug.Log("Obtained Offset: ("+Offset.x+","+Offset.z+")");
CameraMode();
}

function CameraMode()
{switch(camoption.value){
 case 0: CamDefault();break;
 case 1: CamLock();break;
 case 2: DynamicCam();break;
 default: CamDefault();break;
 }
}

function CamDefault()
{transform.position=player.transform.position+ new Vector3(0,6.5,0);}

function CamLock()
{if(Offset.z>2)transform.position.z=player.transform.position.z-2;
else if(Offset.z<-2)transform.position.z=player.transform.position.z+2;
if(Offset.x>2)transform.position.x=player.transform.position.x-2;
else if(Offset.x<-2)transform.position.x=player.transform.position.x+2; }

function DynamicCam()
{}
