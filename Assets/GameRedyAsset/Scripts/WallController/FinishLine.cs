using UnityEngine;

public class FinishLine : MonoBehaviour
{
    [Header("Referances")]
    [SerializeField] private WinLoseUI _winLoseUI;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Consts.WinTag.FINISH_LINE))
        {
            _winLoseUI.OnGameWin();
        }
    }
}
