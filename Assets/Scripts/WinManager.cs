using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinManager : MonoBehaviour
{
    private void Start() {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void Retry() {
        SceneManager.LoadScene("Gameplay");
    }

    public void LoadMainMenu() {
        SceneManager.LoadScene("MainMenu");
    }
}
