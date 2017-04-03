using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManger : MonoBehaviour {

	private int selectedZombiePosition = 0;
	public Text scoreText;
	private int score = 0;
	public GameObject selectedZombie;
	public List<GameObject> zombies;
	public Vector3 selectedSize;
	public Vector3 defaultSize;
	// Use this for initialization
	void Start () {
		SelectZombie(selectedZombie);
		scoreText.text = "Score : " + score;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown("left"))
		{
			GetZombieLeft();
		}
		if (Input.GetKeyDown("right"))
		{
			GetZombieRight();
		}
		if (Input.GetKeyDown("up"))
		{
			PushUp();
		}	
	}

	void GetZombieLeft()
	{
		if (selectedZombiePosition == 0)
		{
			selectedZombiePosition = 3;
			SelectZombie(zombies[selectedZombiePosition]);
		}
		else
		{
			selectedZombiePosition = selectedZombiePosition - 1;
			SelectZombie(zombies[selectedZombiePosition]);
		}	
	}

	void GetZombieRight()
	{
		if (selectedZombiePosition == 3)
		{
			selectedZombiePosition = 0;
			SelectZombie(zombies[selectedZombiePosition]);
		}
		else
		{
			selectedZombiePosition = selectedZombiePosition + 1;
			SelectZombie(zombies[selectedZombiePosition]);
		}
	}

	void SelectZombie(GameObject newZombie)
	{
		selectedZombie.transform.localScale = defaultSize;
		selectedZombie = newZombie;
		selectedZombie.transform.localScale=selectedSize;
	}

	void PushUp()
	{
		Rigidbody rigid = selectedZombie.GetComponent<Rigidbody>();
		rigid.AddForce(0, 0, 10, ForceMode.Impulse);
	}

	public void AddPoint()
	{
		score++;
		scoreText.text = "Score : " + score;
	}
}
