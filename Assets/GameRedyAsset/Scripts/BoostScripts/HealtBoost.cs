using UnityEngine;

public class HealtBoost : MonoBehaviour,IBoostController
{
    public void IBoostMethod()
    {
        //Healt Bost yazılacak
        Debug.Log("Healt Boost alındı");
        Destroy(this.gameObject);
     
     }
}
