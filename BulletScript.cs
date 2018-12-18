using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletScript : MonoBehaviour
{
	public int damage = 1;
	
	public bool isPlayerShot = false;
	
	void Start()
	{
		Destroy(gameObject, 20);
	}

	void OnCollisionEnter2D(Collision2D coll)
	{

		if (coll.gameObject.tag == "Player")
		{
            StageScrolling.levelSurvived = 0;
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
            /*
            Functionality obsolete
            Application.LoadLevel("GameOver");
            */
		}
		
		if (coll.gameObject.tag == "Elevator" || coll.gameObject.tag == "Floor")
		{
			Destroy(gameObject);
		}
		if (coll.gameObject.tag == "Block")
		{
			Physics2D.IgnoreCollision(this.GetComponent<Collider2D>(), coll.collider);

		}
		if (coll.gameObject.tag == "Bullet")
		{
			Physics2D.IgnoreCollision(this.GetComponent<Collider2D>(), coll.collider);
		}
	}
}