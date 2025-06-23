using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelsController : MonoBehaviour
{
    [Header("Referances")]
    [SerializeField] private List<Button> _buttons;

    void Awake()
    {
        _buttons[0].onClick.AddListener(level1Controller);
        _buttons[1].onClick.AddListener(Level2controller);
        _buttons[2].onClick.AddListener(Level3controller);
        _buttons[3].onClick.AddListener(levelfinish);

    }


    private void level1Controller()
    {
        SceneManager.LoadScene(1);
    }

    private void Level2controller()
    {
        if (PlayerPrefs.GetInt("Level2Open") == 2)
        {
            SceneManager.LoadScene(2);
        }

    }
    private void Level3controller()
    {
        if (PlayerPrefs.GetInt("Level3Open") == 3)
        {
            SceneManager.LoadScene(3);
        }
    }

    private void levelfinish()
    {
        if (PlayerPrefs.GetInt("Level?") == 4)
        {
            SceneManager.LoadScene(4);
        }
    }
    



 }
