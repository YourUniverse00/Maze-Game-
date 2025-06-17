using UnityEngine;

public class SpeedBoost : MonoBehaviour, IBoostController
{
    [Header("Referances")]
    [SerializeField] private CharacterController _characterController;
    public void IBoostMethod()
    {
        //Speed Bost yazılacak
        SpeedBost();
        Destroy(this.gameObject);

    }

    public void SpeedBost()
    {
        _characterController.SetMovmentSpeed(30f);
       

    }

    
    
}
