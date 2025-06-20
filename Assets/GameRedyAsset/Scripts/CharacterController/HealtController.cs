using UnityEngine;

public class HealtController : MonoBehaviour
{
    [Header("Referances")]
    [SerializeField] private WinLoseUI _winLoseUI;
    [SerializeField] private HealtUI _healtUI;
    
    [Header("Settings")]
    [SerializeField] public int healt = 3;

    private bool _sethealtbool_1 = true, _sethealtbool_2 = true;

    public void SetHealtDamage()
    {
        if (_sethealtbool_1)
        {
            healt--;
            _healtUI.healtDamage();
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
            if (healt <= 2)
            {
                healt++;
                _sethealtbool_2 = true;
            }

            else
            {
                _sethealtbool_2 = false;
            }
        }
    }















}
