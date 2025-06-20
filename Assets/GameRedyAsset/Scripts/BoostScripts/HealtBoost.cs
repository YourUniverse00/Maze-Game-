using UnityEngine;

public class HealtBoost : MonoBehaviour,IBoostController
{
    [Header("Referances")]
    [SerializeField] private HealtController _healtController;

    [SerializeField] private HealtUI _healtUI;
    public void IBoostMethod()
    {
        //Healt Bost yazılacak
        Debug.Log("Healt Boost alındı");
        _healtUI.HealtBoost();
        _healtController.SetHealtBoost();

        Debug.Log(_healtController.healt);
        Destroy(this.gameObject);

    }
}
