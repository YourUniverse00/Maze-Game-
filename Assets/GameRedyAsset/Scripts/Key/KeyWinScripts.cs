using UnityEngine;

public class KeyWinScripts : MonoBehaviour
{
    [Header("Referances")]
    [SerializeField] private GameObject _door;
    
    private int _keynumber;
    public bool _keybool = true;

    public void OnkeyPlus()
    {
        if (_keybool)
        {
            _keynumber++;
            if (_keynumber >= 4)
            {
                //Win Method
                _door.SetActive(false);
                _keybool = false;
            }

        }
    }



}
