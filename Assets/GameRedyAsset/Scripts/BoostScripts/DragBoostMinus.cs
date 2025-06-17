using UnityEngine;

public class DragBoostMinus : MonoBehaviour, IBoostController
{
    [Header("Referances")]
    [SerializeField] private CharacterController _characterController;
    public void IBoostMethod()
    {
        //Bu method Karakterin Drag özeliği sıfıra çeker 5 saniye sonra eski değerine döndürür 
        DragBoost();
        Destroy(this.gameObject);
    }
     public void DragBoost()
    {
        _characterController.SetdragMinus();
    }
}
