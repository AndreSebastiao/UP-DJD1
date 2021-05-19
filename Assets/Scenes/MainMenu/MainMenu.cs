using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    float Selection;

    [Space(10)]
    [Header("New Game")]
    public GameObject NewGameSprite;
    public GameObject NewGameSelected;

    [Space(10)]
    [Header("Options")]
    public GameObject OptionsSprite;
    public GameObject OptionsSelected;

    [Space(10)]
    [Header("Quit")]
    public GameObject QuitSprite;
    public GameObject QuitSelected;

    void Start()
    {
        Selection = 1;
    }

    void Update()
    {
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
            NewGameSprite.SetActive(false);
            NewGameSelected.SetActive(true);
            OptionsSprite.SetActive(true);
            OptionsSelected.SetActive(false);
            QuitSprite.SetActive(true);
            QuitSelected.SetActive(false);

            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                return;
            }
        }
        if (Selection == 2)
        {
            NewGameSprite.SetActive(true);
            NewGameSelected.SetActive(false);
            OptionsSprite.SetActive(false);
            OptionsSelected.SetActive(true);
            QuitSprite.SetActive(true);
            QuitSelected.SetActive(false);
        }
        if (Selection == 3)
        {
            NewGameSprite.SetActive(true);
            NewGameSelected.SetActive(false);
            OptionsSprite.SetActive(true);
            OptionsSelected.SetActive(false);
            QuitSprite.SetActive(false);
            QuitSelected.SetActive(true);

            if (Input.GetKeyDown(KeyCode.Return))
            {
                Debug.Log("QUIT");
                Application.Quit();
            }
        }
    }
}