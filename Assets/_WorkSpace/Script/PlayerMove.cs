using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Transform _tr;
    Rigidbody _rb;

    Vector3 _move;
    Vector3 _origin;
    Vector3 _front;

    [SerializeField]
    float _moveSpeed;
    void Start()
    {
        _tr = transform;
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _move = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        _tr.position += new Vector3(_move.x * Time.deltaTime * _moveSpeed, 0, _move.z * Time.deltaTime * _moveSpeed);
    }
}
