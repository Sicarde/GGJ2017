using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    public static bool isGamePaused = false;
    public static uint checkpointNB = 0;
    public GameObject creditsGO;
    public GameObject menuGO;

    public void NewGame() {
        checkpointNB = 0;
        Debug.Log("Load Scene 1");
        SceneManager.LoadScene(1);
    }

    public void ContinueGame() {
        SceneManager.LoadScene(1);
    }

    public void Quit() {
        Application.Quit();
    }
    public void Credits() {
        creditsGO.SetActive(true);
        menuGO.SetActive(false);
    }
    public void Return() {
        creditsGO.SetActive(false);
        menuGO.SetActive(true);
    }

    public void Pause() {
        menuGO.SetActive(true);
        isGamePaused = true;
    }

    public void MainMenu() {
        SceneManager.LoadScene(0);
    }

    void Update() {
        if (Input.GetButtonDown("Cancel")) {
            if (isGamePaused) Resume();
            else Pause();
        }
    }

    public void Resume() {
        menuGO.SetActive(false);
        creditsGO.SetActive(false);
        isGamePaused = false;
    }
}
