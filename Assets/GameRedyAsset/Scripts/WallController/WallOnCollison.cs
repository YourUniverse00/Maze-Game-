using UnityEngine;

public class WallOnCollision : MonoBehaviour
{
    [Header("Referances")]
    [SerializeField] private HealtController _healtController;
    private void OnCollisionEnter(Collision collision)
    {
        // Eğer çarpışan nesnenin tag'i "Player" ise
        if (collision.gameObject.tag == "Wall")
        {
            _healtController.SetHealtDamage();
             Debug.Log(_healtController.healt);
            Debug.Log("Duvara temas sağlandı!");
        }
    }
}