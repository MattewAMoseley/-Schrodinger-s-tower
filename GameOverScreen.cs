using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameOverScreen : MonoBehaviour
{
    //Part of depereciated functionality
    private GUISkin skin;

	void Start () {

		skin = Resources.Load("ButtonGUI") as GUISkin;
	}

    //Part of depereciated functionality
    //Functionality can be converted into two seprate functions and linked to a canvas object event handler
    void OnGUI() 
	{
		const int buttonWidth = 200;
		const int instrButtonWidth = 250;
		const int buttonHeight = 65;
		
		GUI.skin = skin;
		
		if(GUI.Button(new Rect(Screen.width/2 - (buttonWidth / 2), (2 * Screen.height / 3) - (buttonHeight / 2), buttonWidth, buttonHeight), "Play Again?"))
		{
            SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
            /*
            Functionality obsolete
            Application.LoadLevel("GameScene");	
            */
        }

        if (GUI.Button(new Rect(Screen.width/2 - (instrButtonWidth / 2), (2 * Screen.height / 2.5f) - (buttonHeight / 2), instrButtonWidth, buttonHeight), "Return to Title"))
		{
            SceneManager.LoadScene("Instructions", LoadSceneMode.Single);
            /*
            Functionality obsolete
            Application.LoadLevel("Instructions");
            */
        }
    }
}
