using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameController : MonoBehaviour {
    // Start is called before the first frame update
    bool isEndGame;
    public GameObject panelEndGame;
    public Text yourPoint;
    public Button restartButton;
    void Start () {
        Time.timeScale = 0;
        isEndGame = false;
        panelEndGame.SetActive (false);

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown ("Jump") && !isEndGame) {
            Time.timeScale = 1;
        }
    }
    public void StartGame () {
        SceneManager.LoadScene (0);

    }
    public void RestratGame () {
        StartGame ();
    }
    public void EndGame () {
        Debug.Log ("end game");
        Time.timeScale = 0;
        isEndGame = true;
        panelEndGame.SetActive (true);
    }
}