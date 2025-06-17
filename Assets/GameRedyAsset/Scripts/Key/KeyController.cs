using UnityEngine;

public class KeyController : MonoBehaviour, IBoostController
{
    
    public void IBoostMethod()
    {
        //Key mekanikleri yazılacak
        Debug.Log("+1 Key alındı ");
        Destroy(this.gameObject);
     
     }
  
}
