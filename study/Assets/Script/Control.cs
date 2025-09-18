using UnityEngine;

public class Control : MonoBehaviour
{
    public Vector3 dir;
    Rigidbody rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        dir.x = Input.GetAxis("Horizontal");
        dir.z = Input.GetAxis("Vertical");
        dir.Normalize();
    }

    private void FixedUpdate()
    {
        rigid.AddForce(dir,ForceMode.Force);

    }

    public void Jump()
    {
        rigid.AddForce(Vector3.up*Time.fixedDeltaTime,ForceMode.Impulse);
    }
}
