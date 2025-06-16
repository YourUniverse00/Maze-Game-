using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [Header("Referances")]
    [SerializeField] private Rigidbody _playerRigidyBody;
    [Header("Settings")]
    [SerializeField] private float _speed;

    void Awake()
    {
        _playerRigidyBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        PlayerAddForce();
    }

    private void PlayerAddForce()
    {
        float input_x = Input.GetAxis("Horizontal");
        float input_y = Input.GetAxis("Vertical");
        Vector3 _playeraddforce = new Vector3(input_x, 0f, input_y).normalized;

        _playerRigidyBody.AddForce(_playeraddforce * _speed, ForceMode.Force);
    }
}
