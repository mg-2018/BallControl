﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuideText : MonoBehaviour
{
	RectTransform rt;
	Text guideText;
	Ball playerBall;
	
	// Start is called before the first frame update
	void Start()
	{
		rt = gameObject.GetComponent<RectTransform>();
		guideText = gameObject.GetComponent<Text>();
		playerBall = FindObjectOfType<Ball>();
	}

	// Update is called once per frame
	void Update()
	{
		guideText.alignment = TextAnchor.MiddleCenter;
		guideText.color = Color.white;

		switch (playerBall.CurStage)
		{
			case 1:
				rt.anchoredPosition = new Vector2(0f, -30f);
				guideText.text = 
					"Left/Right arrow to move\n<size=16>Press ESC anytime to go back to main screen</size>";
				break;
				
			case 2:
				rt.anchoredPosition = new Vector2(0f, -30f);
				guideText.text = "Up arrow to jump";
				break;
				
			case 3:
				rt.anchoredPosition = new Vector2(0f, 150f);
				guideText.text = 
					"Be careful of that red thingy\n<size=16>That makes you to go back to start position</size>";
				break;
				
			case 4:
				rt.anchoredPosition = new Vector2(0f, 180f);
				guideText.text = "Jump past that red thingy";
				break;
				
			case 5:
				rt.anchoredPosition = new Vector2(0f, -165f);
				guideText.text = "Added one more layer!\n<size=16>Good luck</size>";
				break;
				
			case 6:
				rt.anchoredPosition = new Vector2(0f, 30f);
				guideText.text = "Dash Usage\n<size=16>Hold arrow key and press \'Z\'</size>";
				break;
				
			case 7:
				rt.anchoredPosition = new Vector2(0f, 120f);
				guideText.text = "Just one dash.. with control!!";
				break;

			case 8:
				rt.anchoredPosition = new Vector2(0f, 120f);
				guideText.alignment = TextAnchor.MiddleRight;
				guideText.text = "Get ready for more controls!";
				break;
				
			case 9:
				rt.anchoredPosition = new Vector2(0f, 80f);
				guideText.text = "Using dashes in a row!!";
				break;
				
			case 10:
				rt.anchoredPosition = new Vector2(0f, 30f);
				guideText.text = "Jump Usage\n<size=16>Hold arrow key and press \'X\'</size>";
				break;
				
			case 11:
				rt.anchoredPosition = new Vector2(0f, 80f);
				guideText.alignment = TextAnchor.MiddleLeft;
				guideText.text = "6 jumps in a row.. again!!";
				break;
				
			case 12:
				rt.anchoredPosition = new Vector2(0f, -210f);
				guideText.text = "Don\'t get confused.. There\'re two items now!";
				break;
				
			case 13:
				rt.anchoredPosition = new Vector2(0f, 225f);
				guideText.text = "More item changes\n<size=16>and increasing difficulty</size>";
				break;

			case 14:
				rt.anchoredPosition = new Vector2(0f, 250f);
				guideText.alignment = TextAnchor.MiddleLeft;
				guideText.text = "Challenge accepted: jumping over the wall";
				break;

			case 15:
				rt.anchoredPosition = new Vector2(0f, -135f);
				guideText.alignment = TextAnchor.MiddleRight;
				guideText.text = "Everything gets trickier...";
				break;

			case 16:
				rt.anchoredPosition = new Vector2(0f, 0f);
				guideText.alignment = TextAnchor.MiddleLeft;
				guideText.text = "Isn\'t that.. the turret?!";
				break;

			case 17:
				rt.anchoredPosition = new Vector2(0f, -155f);
				guideText.alignment = TextAnchor.MiddleLeft;
				guideText.text = "They shoot towards even left or right!";
				break;

			case 18:
				rt.anchoredPosition = new Vector2(0f, -255f);
				guideText.alignment = TextAnchor.MiddleRight;
				guideText.text = "What if you pass through the bullets?";
				break;

			case 19:
				rt.anchoredPosition = new Vector2(0f, 265f);
				guideText.alignment = TextAnchor.MiddleLeft;
				guideText.text = "I can\'t decide either easier or harder than it looks...";
				break;

			case 20:
				rt.anchoredPosition = new Vector2(0f, -230f);
				guideText.alignment = TextAnchor.MiddleRight;
				guideText.text = "How dare you climb onto this?!";
				break;

			case 21:
				rt.anchoredPosition = new Vector2(0f, 185f);
				guideText.alignment = TextAnchor.MiddleLeft;
				guideText.text = "Much easier than previous stage.. maybe";
				break;

			default:
				rt.anchoredPosition = new Vector2(0f, 0f);
				guideText.text = "More stages coming soon...";
				break;
		}
	}
}