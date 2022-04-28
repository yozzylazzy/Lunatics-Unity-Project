using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadingScreen : MonoBehaviour {
	AsyncOperation loading;
	public Slider progressBar;
	public Text percentLoaded;

	// Use this for initialization
	void Start () {
		loading = SceneManager.LoadSceneAsync(0);
	}
	
	// Update is called once per frame
	void Update () {
		float loadProgress = loading.progress;
		progressBar.value = Mathf.Clamp01(loadProgress / 0.9f);
		float progressV = Mathf.Clamp01(loadProgress / 0.9f);
		percentLoaded.text = Mathf.Round(progressV * 100) + "%";
        if (loading.isDone)
        {
			Debug.Log("Entering The Game");
        }
	}
}
