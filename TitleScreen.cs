using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class TitleScreen : MonoBehaviour
{

    //Part of depereciated functionality
    private GUISkin skin;

	void Start () 
	{
		skin = Resources.Load("ButtonGUI") as GUISkin;
	}

    //Part of depereciated functionality
    //Functionality can be converted into two seprate functions and linked to a canvas object event handler
	void OnGUI() 
	{
		const int buttonWidth = 100;
		const int instrButtonWidth = 200;
		const int buttonHeight = 45;

		GUI.skin = skin;

		if(GUI.Button(new Rect(Screen.width/2 - (buttonWidth / 2), (2 * Screen.height / 3) - (buttonHeight / 2) + 75, buttonWidth, buttonHeight), "Start"))
		{
            SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
            /*
            Functionality obsolete
            Application.LoadLevel("GameScene");	
            */
		}

		if(GUI.Button(new Rect(Screen.width/2 - (instrButtonWidth / 2), (2 * Screen.height / 3) - (buttonHeight / 2) + 125, instrButtonWidth, buttonHeight), "How to Play"))
		{
            SceneManager.LoadScene("Instructions", LoadSceneMode.Single);
            /*
            Functionality obsolete
            Application.LoadLevel("Instructions");
            */
		}
	}
}
