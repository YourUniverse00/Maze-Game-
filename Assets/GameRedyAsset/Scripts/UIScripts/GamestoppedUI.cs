using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class GamestoppedUI : MonoBehaviour
{
    [Header("Referances")]
    [SerializeField] private GameObject _gameStop;
    [SerializeField] private Button _continuebutton;
    [SerializeField] private Button _gamestopbutton;
    [SerializeField] private CharacterController _characterController;
    [SerializeField] private TimerUI _timerUI;
    [SerializeField] private Rigidbody _player;

    private RectTransform _gamstopRectransform;

    void Awake()
    {
        _gamstopRectransform = _gameStop.GetComponent<RectTransform>();
        _gamestopbutton.onClick.AddListener(Gamestop);
        _continuebutton.onClick.AddListener(Continue);
    }

    public void Gamestop()
    {
        _player.isKinematic = true; 
        _timerUI.StopTimer();
        _characterController._ongamewinlose = false;
        _gameStop.SetActive(true);
        _gamstopRectransform.DOScale(1f, 0.4f).SetEase(Ease.InCubic);
    }

    public void Continue()
    {
        _player.isKinematic = false;
        _timerUI.StartTimer();
        _gamstopRectransform.DOScale(.5f, 0.4f)
       .SetEase(Ease.InCubic)
       .OnComplete(() => _gameStop.SetActive(false));
        _characterController._ongamewinlose = true;
    }
}
