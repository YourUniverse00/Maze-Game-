using UnityEngine;

public class BoostControllerScripts : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<IBoostController>(out var ıboostcontroller))
        {
            ıboostcontroller.IBoostMethod();
        }
    }
}
