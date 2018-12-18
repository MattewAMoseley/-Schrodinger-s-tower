using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Instructions : MonoBehaviour
{

	private GUISkin skin;

	void Start () 
	{
		skin = Resources.Load("ButtonGUI") as GUISkin;
	}
    //Part of depereciated functionality
    //Functionality can be converted into a custom function and linked to a canvas object event handler
    void OnGUI() 
	{
		const int buttonWidth = 200;
		const int buttonHeight = 65;
		
		GUI.skin = skin;
		
		if(GUI.Button(new Rect(Screen.width/2 - (buttonWidth / 2), (2 * Screen.height / 3 + 150) - (buttonHeight / 2), buttonWidth, buttonHeight), "Back"))
		{
            SceneManager.LoadScene("StartScreen", LoadSceneMode.Single);
            /*
            Functionality obsolete
            Application.LoadLevel("StartScreen");	
            */
		}

	}
}