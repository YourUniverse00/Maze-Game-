using DG.Tweening;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinLoseUI : MonoBehaviour
{
      public event Action OnSpeedBoost;

    [Header("Referances")]
    [SerializeField] private GameObject _winPopup;
    [SerializeField] private GameObject _losePopup;
    [SerializeField] private CharacterController _characterController;

    [SerializeField] private Button _tryAgain,_tryAgain2, _menu,_menu2,_menu3;
    [SerializeField] private TimerUI _timerUI;

    [Header("Settings")]
    [SerializeField] private float _animationDuraction;

    private RectTransform _winPopupTransform;
    private RectTransform _losePopupTransform;

    const string level2 = "Level 2";

    public int levelopen;

    void Awake()
    {
        levelopen = SceneManager.GetActiveScene().buildIndex;
        _tryAgain.onClick.AddListener(TryAgainButton);
      _tryAgain2.onClick.AddListener(TryAgainButton);
        _menu.onClick.AddListener(MenuButton);
        _menu2.onClick.AddListener(MenuButton);
        _menu3.onClick.AddListener(MenuButton);
        _winPopupTransform = _winPopup.GetComponent<RectTransform>();
        _losePopupTransform = _losePopup.GetComponent<RectTransform>();
    }

    public void OnGameWin()
    {

        _timerUI.StopTimer();
        _characterController._ongamewinlose = false;
        _winPopup.SetActive(true);
        _winPopupTransform.DOScale(1f, _animationDuraction).SetEase(Ease.OutCirc);
        OnSpeedBoost?.Invoke();

        if (levelopen == 1)
        {
            PlayerPrefs.SetInt("Level2Open", 2);
            PlayerPrefs.Save();
        }
        if (levelopen == 2)
        {
            PlayerPrefs.SetInt("Level3Open", 3);
            PlayerPrefs.Save();
        }
        if (levelopen == 3)
        {
            PlayerPrefs.SetInt("Level?",4);
            PlayerPrefs.Save();
        }
        
    }
    public void OnGameLose()
    {
        _timerUI.StopTimer();
        _characterController._ongamewinlose = false;
        _losePopup.SetActive(true);
        _losePopupTransform.DOScale(1f, _animationDuraction).SetEase(Ease.OutCirc);
    }

    private void TryAgainButton()
    {
        //Kod işlevli olması için mevcut olduğu level sahnesini yüklemeli 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void MenuButton()
    {
        SceneManager.LoadScene(0);
    }

}
