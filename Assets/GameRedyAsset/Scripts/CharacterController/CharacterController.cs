using System.Collections;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [Header("Referances")]
    [SerializeField] private Rigidbody _playerRigidyBody;
    [SerializeField] private CameraFollow _cameraFollow;
    [Header("Settings")]
    [SerializeField] private float _speed;

    private float _startspeed;

    private Vector3 _offsetvector;

    void Awake()
    {
    _offsetvector = _cameraFollow.offset;
        _startspeed = _speed;
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


    //Boosterların çalışması için destek methodlar 

    public void SetdragMinus()
    {
        _playerRigidyBody.linearDamping = 0f;
        Invoke(nameof(RespawnDragMinus), 5F);
    }
    public void RespawnDragMinus()
    {
        _playerRigidyBody.linearDamping = 2f;
    }

    public void SetdragPlus()
    {
        _playerRigidyBody.linearDamping = 10f;
        Invoke(nameof(RespawnDragPlus), 5f);
    }
    public void RespawnDragPlus()
    {
        _playerRigidyBody.linearDamping = 2f;
    }
    public void SetMovmentSpeed(float newspeed)
    {
        _speed += newspeed;
        StartCoroutine(ChangeOffsetSmoothly(new Vector3(_offsetvector.x, 4.28f, -3.96f), 0.8f));
        Invoke(nameof(ResetMovmentSpeed), 5f);
    }
    public void ResetMovmentSpeed()
    {
        StartCoroutine(ChangeOffsetSmoothly(_offsetvector, 1f));
        _speed = _startspeed;
    }
        private IEnumerator ChangeOffsetSmoothly(Vector3 targetOffset, float duration)
    {
        Vector3 startOffset = _cameraFollow.offset;
        float elapsed = 0f;

        while (elapsed < duration)
        {
            _cameraFollow.offset = Vector3.Lerp(startOffset, targetOffset, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }

        _cameraFollow.offset = targetOffset;
    }

}
