using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class MenuButtonsControlle : MonoBehaviour
{
    [Header("Referances")]
    [SerializeField] private Button _playButton;
    [SerializeField] private Button _levelspopusclose;
    [SerializeField] private Button _quitButtons;
    [SerializeField] private GameObject _levelsPopup;
    [SerializeField] private GameObject _levelpopup2;

    private RectTransform _levelspopup;


    void Awake()
    {
        _levelspopup = _levelpopup2.GetComponent<RectTransform>();
        _playButton.onClick.AddListener(PlayButton);
        _quitButtons.onClick.AddListener(QuitButton);
        _levelspopusclose.onClick.AddListener(LevelsPopupClose);
    }

    private void PlayButton()
    {
        _levelspopup.DOScale(1f, .5f).SetEase(Ease.InCubic);
        _levelsPopup.SetActive(true);
    }
    private void LevelsPopupClose()
    {
        _levelspopup.DOScale(.5f, .5f).SetEase(Ease.InCubic).OnComplete(() => _levelsPopup.SetActive(false));

    }

    private void QuitButton()
    {
        Application.Quit();
    }
    
}
