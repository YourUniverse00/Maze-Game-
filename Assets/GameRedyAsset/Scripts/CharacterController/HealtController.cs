using UnityEngine;

public class HealtController : MonoBehaviour
{
    [Header("Referances")]
    [SerializeField] private WinLoseUI _winLoseUI;
    
    [Header("Settings")]
    [SerializeField] public int healt = 3;

    private bool _sethealtbool_1 = true, _sethealtbool_2 = true;

    public void SetHealtDamage()
    {
        if (_sethealtbool_1)
        {
            healt--;
            if (healt <= 0)
            {
                _winLoseUI.OnGameLose();
                _sethealtbool_1 = false;
            }
        }


    }

    public void SetHealtBoost()
    {
        if (_sethealtbool_2)
        {
            healt++;
            if (healt <= 0)
            {
                _sethealtbool_2 = false;
            }
        }
    }















}
