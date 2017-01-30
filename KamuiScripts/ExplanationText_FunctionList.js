#pragma strict
import UnityEngine.UI;

function Start () {

}

function Update () {

}

public function NewGameButton(exp:Text)
{exp.text="Start a New Game from the first Level.";}

public function ResumeButtonText(exp:Text)
{exp.text="Resume the Game";}

public function SelectLevelButtonText(exp:Text)
{exp.text="Select the level you wish to load";}

public function CameraButtonText(exp:Text)
{exp.text="Change the Camera Settings";}

public function ControlsButtonText(exp:Text)
{exp.text="Control scheme for our game";}

public function MainMenuButtonText(exp:Text)
{exp.text="Back to Main Menu";}

public function ExitButton(exp:Text)
{exp.text="Exit the Game";}

public function CamMode(exp:Text)
{exp.text="Change the way the camera behaves. Select: \n '1' for default camera view \n '2' for 3D overhead camera view, \n '3' for rotatable camera ";}

public function CamFOV(exp:Text)
{exp.text="Change the camera's field of view (FOV). Smaller FOV means narrower view of the camera.";}

public function ClearText(exp:Text)
{exp.text="";}