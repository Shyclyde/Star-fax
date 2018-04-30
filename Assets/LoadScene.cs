using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    void Awake() {
        DontDestroyOnLoad(gameObject);
    }

    // Use this for initialization
    void Start () {
        Invoke("LoadNextScene", 2f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void LoadNextScene() {
        
        SceneManager.LoadScene(1);
    }
}
