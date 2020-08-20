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
    public int point = 0;
    public int level = 1;
    public Text currentPoint;
    public Text currentLevel;
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
        yourPoint.text = "Your Point: " + point.ToString ();
    }
    public void increasePoint () {
        point += 100;
        currentPoint.text = "Point: " + point.ToString ();
        if (point > 0 && !isEndGame && point % 100 == 0) {
            level += 1;
            currentLevel.text = "Level: " + level.ToString ();
        }
    }

}