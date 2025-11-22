using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class PlayerMove : MonoBehaviour
{
    Transform _tr;
    Rigidbody _rb;

    Vector3 _move;
    Vector3 _origin;
    Vector3 _front;

    [SerializeField]
    float _moveSpeed;
    [SerializeField]
    float _jumpPower;
    void Start()
    {
        _tr = transform;
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        #region ˆÚ“®
        _move = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        _tr.position += new Vector3(_move.x * Time.deltaTime * _moveSpeed, 0, _move.z * Time.deltaTime * _moveSpeed);
        #endregion

        #region ƒWƒƒƒ“ƒv
        //Ú’n”»’è‚Ìˆ—‚ğ’Ç‰Á—\’è
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(0, _jumpPower, 0);
        }
        #endregion

        #region UŒ‚

        #endregion
    }
}
