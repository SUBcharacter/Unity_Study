using UnityEngine;

public class Character : MonoBehaviour
{
    public Vector3 direction;

    private void Awake()
    {
        
    }
    private void Start()
    {
        transform.position = new Vector3(10.0f, 10.0f, 10.0f);
        Debug.Log(transform.position);
    }

    private void Update()
    {
        direction = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical"));
        direction.Normalize();

        // Time.deltaTime
        // 마지막 프레임 이후의 완료되는 시간
        
        transform.position += direction * 100.0f * Time.deltaTime;
       
        
        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.position += Vector3.forward * Time.deltaTime;
        //}
        //if(Input.GetKey(KeyCode.S))
        //{
        //    transform.position += Vector3.back * Time.deltaTime;
        //}
        //if(Input.GetKey(KeyCode.D))
        //{
        //    transform.position += new Vector3(Input.GetAxis("Horizontal"),0,0) * Time.deltaTime;
        //}
        //if(Input.GetKey(KeyCode.A))
        //{
        //    transform.position += Vector3.left * Time.deltaTime;
        //}
        //if(Input.GetKey(KeyCode.Space))
        //{
        //    transform.position += Vector3.up * Time.deltaTime;
        //}
        //if(Input.GetKey(KeyCode.LeftShift))
        //{
        //    transform.position += Vector3.down * Time.deltaTime;
        //}
    }
}
