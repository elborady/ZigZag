using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{	
	public static MenuController instance;
	[SerializeField] GameObject gameOverPanel;
	[SerializeField] GameObject mainPanel;
	[SerializeField] int gameLevelNumber;

	private void OnEnable()
	{
		instance = this;
	}

	public void GameOver()
	{
		gameOverPanel.SetActive(true);
		mainPanel.SetActive(false);
	}

	public void Restart()
	{
		SceneManager.LoadScene(gameLevelNumber);
	}

    public void TurnButton()
	{
		if(!BallController.instance.isStarted)
		{
			BallController.instance.isStarted = true;
		}
		BallController.instance.isGoingRight = !BallController.instance.isGoingRight;
	}
}
