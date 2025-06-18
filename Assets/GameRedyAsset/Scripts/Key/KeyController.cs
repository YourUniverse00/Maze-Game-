using UnityEngine;

public class KeyController : MonoBehaviour, IBoostController
{
    [Header("Referances")]
    [SerializeField] private KeyWinScripts _keyWinScripts;
    
    public void IBoostMethod()
    {
        //Key mekanikleri yazılacak
        Debug.Log("+1 Key alındı ");
        _keyWinScripts.OnkeyPlus();
        Destroy(this.gameObject);

    }
  
}
