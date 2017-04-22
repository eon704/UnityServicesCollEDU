using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class AnalyticsScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		LevelUp ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void LevelUp() {
		Analytics.CustomEvent("gameOver", new Dictionary<string, object>
		{
			{ "newLevel", 2 },
			{ "trigger", "levelEnd" }
		});
		Analytics.Transaction("Sword", 1, "USD", null, null);
		Gender gender = Gender.Unknown;
		Analytics.SetUserGender(gender);

		int birthYear = 2000;
		Analytics.SetUserBirthYear(birthYear);
	}
}
