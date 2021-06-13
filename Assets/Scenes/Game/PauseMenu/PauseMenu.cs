using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    float Selection;

    [Space(10)]
    [Header("Resume")]
    public GameObject PResumeSprite;
    public GameObject PResumeSelected;

    [Space(10)]
    [Header("Options")]
    public GameObject POptionsSprite;
    public GameObject POptionsSelected;

    [Space(10)]
    [Header("Quit")]
    public GameObject PQuitSprite;
    public GameObject PQuitSelected;

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    void Start()
    {
        Selection = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (Selection <= 3)
            {
                Selection++;
            }
            if (Selection > 3)
            {
                Selection = 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (Selection >= 1)
            {
                Selection--;
            }
            if (Selection < 1)
            {
                Selection = 3;
            }
        }

        if (Selection == 1)
        {
            PResumeSprite.SetActive(false);
            PResumeSelected.SetActive(true);
            POptionsSprite.SetActive(true);
            POptionsSelected.SetActive(false);
            PQuitSprite.SetActive(true);
            PQuitSelected.SetActive(false);

            if (Input.GetKeyDown(KeyCode.Return))
            {
                Resume();
                return;
            }
        }
        if (Selection == 2)
        {
            PResumeSprite.SetActive(true);
            PResumeSelected.SetActive(false);
            POptionsSprite.SetActive(false);
            POptionsSelected.SetActive(true);
            PQuitSprite.SetActive(true);
            PQuitSelected.SetActive(false);
        }
        if (Selection == 3)
        {
            PResumeSprite.SetActive(true);
            PResumeSelected.SetActive(false);
            POptionsSprite.SetActive(true);
            POptionsSelected.SetActive(false);
            PQuitSprite.SetActive(false);
            PQuitSelected.SetActive(true);

            if (Input.GetKeyDown(KeyCode.Return))
            {
                Debug.Log("QUIT");
                Application.Quit();
            }
        }
    }

    public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
