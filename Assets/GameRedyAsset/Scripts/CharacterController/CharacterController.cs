using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [Header("Referances")]
    [SerializeField] private Rigidbody _playerRigidyBody;
    [Header("Settings")]
    [SerializeField] private float _speed;

    private float _startspeed;

    void Awake()
    {
        _startspeed += _speed;
        _playerRigidyBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        PlayerAddForce();
    }

    public void SetMovmentSpeed(float newspeed)
    {
        _speed += newspeed;
        Invoke(nameof(ResetMovmentSpeed),5f);
    }
    public void ResetMovmentSpeed()
    {
        _speed = _startspeed;
    }

    private void PlayerAddForce()
    {
        float input_x = Input.GetAxis("Horizontal");
        float input_y = Input.GetAxis("Vertical");
        Vector3 _playeraddforce = new Vector3(input_x, 0f, input_y).normalized;

        _playerRigidyBody.AddForce(_playeraddforce * _speed, ForceMode.Force);
    }
}
