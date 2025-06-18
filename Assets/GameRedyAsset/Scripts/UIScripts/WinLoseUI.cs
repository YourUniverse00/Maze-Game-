using DG.Tweening;
using UnityEngine;

public class WinLoseUI : MonoBehaviour
{
    [Header("Referances")]
    [SerializeField] private GameObject _winPopup;
    [SerializeField] private GameObject _losePopup;

    [Header("Settings")]
    [SerializeField] private float _animationDuraction;

    private RectTransform _winPopupTransform;
    private RectTransform _losePopupTransform;

    void Awake()
    {
        _winPopupTransform = _winPopup.GetComponent<RectTransform>();
        _losePopupTransform = _losePopup.GetComponent<RectTransform>();
    }

    public void OnGameWin()
    {
        _winPopup.SetActive(true);
        _winPopupTransform.DOScale(1f, _animationDuraction).SetEase(Ease.OutCirc);
    }
     public void OnGameLose()
    {
        _losePopup.SetActive(true);
        _losePopupTransform.DOScale(1f, _animationDuraction).SetEase(Ease.OutCirc);
    }
}
