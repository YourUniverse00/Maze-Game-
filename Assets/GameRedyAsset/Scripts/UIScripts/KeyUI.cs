using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class KeyUI : MonoBehaviour
{
    [Header("Referances")]
    [SerializeField] private List<Image> _KeyUI;
    [SerializeField] private Sprite _keyOn;

    public void KeyGetThe()
    {
        for (int i = 0; i < _KeyUI.Count; i++)
        {
            if (_KeyUI[i].sprite != _keyOn)
            {
                _KeyUI[i].sprite = _keyOn;
                break;
            }
        }
    }

}
