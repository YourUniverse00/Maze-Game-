using UnityEngine;

public class DragBoostPlus : MonoBehaviour ,IBoostController
{
    public void IBoostMethod()
    {
        //DragPlus Bost yazılacak
        Debug.Log("DragPlus Boost alındı");
        Destroy(this.gameObject);
     
     }
}
