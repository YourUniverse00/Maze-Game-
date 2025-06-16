using UnityEngine;

public class WallOnCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Eğer çarpışan nesnenin tag'i "Player" ise
        if (collision.gameObject.tag == "Wall")
        {
            Debug.Log("Duvara temas sağlandı!");
        }
    }
}