using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Header("Referances")]
    [SerializeField] private Transform _playerTransform;
    [SerializeField] public Vector3 offset;
    [SerializeField] private float smoothspeed = 5F;

    void FixedUpdate()
    {
        Vector3 desiredPosition = _playerTransform.position + offset;

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition,smoothspeed);

        transform.position = smoothedPosition;

        transform.LookAt(_playerTransform);
    }




}
