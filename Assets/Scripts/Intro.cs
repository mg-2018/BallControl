﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
	GameObject BGM;

	public static int Current = 1;
	public static int Maximum = 1;
	// furthest stage are stored in this 'Maximum' variable

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

		startGame.GetComponentInChildren<Text>().text = "Start\n<size=16>(From Stage1)</size>";

		BGM = GameObject.Find("BGM");
	}

	IEnumerator Intro2Main()
	{
		Scene currentScene = SceneManager.GetActiveScene();

		AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("World", LoadSceneMode.Additive);

		while(!asyncLoad.isDone)
			yield return null;

		SceneManager.MoveGameObjectToScene(BGM, SceneManager.GetSceneByName("World"));
		SceneManager.UnloadSceneAsync(currentScene);
	}
	// big thanks to unity scripting API

	IEnumerator Intro2Selection()
	{
		Scene currentScene = SceneManager.GetActiveScene();

		AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Select", LoadSceneMode.Additive);

		while (!asyncLoad.isDone)
			yield return null;

		SceneManager.MoveGameObjectToScene(BGM, SceneManager.GetSceneByName("Select"));
		SceneManager.UnloadSceneAsync(currentScene);
	}

	void GotoStage1()
	{
		Current = 1;
		StartCoroutine(Intro2Main());
	}

	void GotoRecent()
	{
		Current = Maximum;
		StartCoroutine(Intro2Main());
	}

	void GotoSelect()
	{
		StartCoroutine(Intro2Selection());
	}

	// Update is called once per frame
	void Update()
	{
		startFromRecent.GetComponentInChildren<Text>().text =
			$"<size=32>Continue</size>\n<size=16>Current: {Maximum}</size>";
	}
}
