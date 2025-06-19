using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButtonsControlle : MonoBehaviour
{
    [Header("Referances")]
    [SerializeField] private Button _playButton;

    void Awake()
    {
        _playButton.onClick.AddListener(PlayButton);
    }

    private void PlayButton()
    {
        SceneManager.LoadScene(1);
    }
}
