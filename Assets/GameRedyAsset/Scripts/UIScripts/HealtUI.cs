using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HealtUI : MonoBehaviour
{
    [Header("Referances")]
    [SerializeField] private List<Image> _healtUI;
    [SerializeField] private Sprite _healtoff;
    [SerializeField] private Sprite _healtOn;

    public void healtDamage()
    {
        for (int i = 0; i < _healtUI.Count; i++)
        {
            if (_healtUI[i].sprite != _healtoff)
            {
                _healtUI[i].sprite = _healtoff;
                break;
            }
        }
    }

    public void HealtBoost()
    {
        for (int i = _healtUI.Count - 2; i >= 0; i--)
        {
            if (_healtUI[i].sprite == _healtoff)
            {
                _healtUI[i].sprite = _healtOn;
                break;
            }
        }

    }



}
