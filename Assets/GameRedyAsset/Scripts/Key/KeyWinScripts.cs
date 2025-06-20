using UnityEngine;

public class KeyWinScripts : MonoBehaviour
{
    [Header("Referances")]
    [SerializeField] private GameObject _door;
    [SerializeField] private KeyUI _keyUI;
    
    private int _keynumber;
    public bool _keybool = true;

    public void OnkeyPlus()
    {
        if (_keybool)
        {
            _keynumber++;
            _keyUI.KeyGetThe();
            if (_keynumber >= 4)
            {
                //Win Method
                _door.SetActive(false);
                _keybool = false;
            }

        }
    }



}
