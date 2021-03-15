﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
	float alpha = 0f;
	GameObject BGM;

	public static int current = 1;

	public Button startGame;
	public Button startFromRecent;
	public Button stageSelect;
	public Text NA;

	// Start is called before the first frame update
	void Start()
	{
		startGame.onClick.AddListener(GotoStage1);
		startFromRecent.onClick.AddListener(GotoRecent);
		stageSelect.onClick.AddListener(GotoSelect);

		NA.color = new Color(1f, 0f, 0f, 0f);

		startGame.GetComponentInChildren<Text>().text = "Start\n<size=16>(Reset progress)</size>";

		BGM = GameObject.Find("BGM");
	}

	IEnumerator Intro2Main()
	{
		Scene currentScene = SceneManager.GetActiveScene();

		AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("World", LoadSceneMode.Additive);

		while(!asyncLoad.isDone)
		{
			yield return null;
		}

		SceneManager.MoveGameObjectToScene(BGM, SceneManager.GetSceneByName("World"));
		SceneManager.UnloadSceneAsync(currentScene);
	}

	void GotoStage1()
	{
		current = 1;
		StartCoroutine(Intro2Main());
	}

	void GotoRecent()
	{
		StartCoroutine(Intro2Main());
	}

	void GotoSelect()
	{
		alpha = 1f;
	}

	// Update is called once per frame
	void Update()
	{
		startFromRecent.GetComponentInChildren<Text>().text = 
			$"<size=32>Continue</size>\n<size=16>Current: {current}</size>";

		if (alpha > 0f)
		{
			alpha -= Time.deltaTime / 2f;
		}

		NA.color = new Color(1f, 0f, 0f, Mathf.Lerp(0f, 1f, alpha));
	}
}
