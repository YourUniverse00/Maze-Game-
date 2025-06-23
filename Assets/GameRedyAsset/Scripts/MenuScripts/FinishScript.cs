using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinishScript : MonoBehaviour
{
    [Header("Referances")]
    [SerializeField] private Button _menubutton;
    [SerializeField] private RectTransform _black;
    void Awake()
    {
        _black.DOScale(0f, .8f).SetEase(Ease.InOutQuart);
        _menubutton.onClick.AddListener(Menubutton);
    }

    private void Menubutton()
    {
        SceneManager.LoadScene(0);
    }
}
