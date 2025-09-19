using UnityEngine;

public class Control : MonoBehaviour
{
    Rigidbody rigid;
    public Vector3 dir;
    [SerializeField] ForceMode forceMode;
    [SerializeField] float speed;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        forceMode = ForceMode.Force;
        speed = 5.0f;
    }

    public void Init()
    {
        dir = Vector3.zero;
        speed = 5.0f;
        forceMode = ForceMode.Force;
    }

    private void Update()
    {
        dir.x = Input.GetAxis("Horizontal");
        dir.z = Input.GetAxis("Vertical");
        dir.Normalize();
    }

    private void FixedUpdate()
    {
        rigid.AddForce(dir *speed, forceMode);

    }

    public void Jump()
    {
        speed = 1;
        dir = Vector3.up;
        forceMode = ForceMode.Impulse;
    }

}
