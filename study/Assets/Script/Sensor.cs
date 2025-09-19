using UnityEngine;

public class Sensor : MonoBehaviour
{
    [SerializeField] bool trigger = false;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("충돌");

        if (!other.CompareTag("Ball"))
            return;
        other.GetComponent<Control>().Jump();
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("충돌 중");

        if (!other.CompareTag("Ball"))
            return;
        
        
        
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("해제");
        if (!other.CompareTag("Ball"))
            return;
        other.GetComponent<Control>().Init();
    }
}
