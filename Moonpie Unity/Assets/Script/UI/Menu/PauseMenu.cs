using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool paused = false;
    public GameObject pauseMenuCanvas;
    public GameObject mainCamera;


    void Start()
    {
        Time.timeScale = 1.0f;

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
                Play();
            }
            else
            {
                Stop();
            }
        }

    }

    void Stop()
    {
        pauseMenuCanvas.SetActive(true);
        Time.timeScale = 0f;
        paused = true;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        mainCamera.GetComponent<CameraManager>().enabled = false;
    }

    public void Play()
    {

        pauseMenuCanvas.SetActive(false);
        Time.timeScale = 1f;
        paused = false;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        mainCamera.GetComponent<CameraManager>().enabled = true;
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
