using UnityEngine;

public class DragBoostPlus : MonoBehaviour, IBoostController
{
    [Header("Referances")]
    [SerializeField] private CharacterController _characterController;
    public void IBoostMethod()
    {
        //Bu boost Drag değerini artırır ve 10 yapar 
        DragBoost();
        Destroy(this.gameObject);
    }

    public void DragBoost()
    {
        _characterController.SetdragPlus();
    }
}
