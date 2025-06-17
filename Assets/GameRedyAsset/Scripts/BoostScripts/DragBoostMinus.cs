using UnityEngine;

public class DragBoostMinus : MonoBehaviour,IBoostController
{
    public void IBoostMethod()
    {
        //DragMinus Bost yazılacak
        Debug.Log("DragMinus Boost alındı");
        Destroy(this.gameObject);
     
     }
}
