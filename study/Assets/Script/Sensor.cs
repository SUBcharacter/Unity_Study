using UnityEngine;

public class Sensor : MonoBehaviour
{
    [SerializeField] bool trigger = false;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("충돌");

        if (!other.CompareTag("Ball"))
            return;
        trigger = true;
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("충돌 중");

        if (!other.CompareTag("Ball"))
            return;
        trigger = true;
        other.GetComponent<Control>().Jump();
        
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("해제");
        if (!other.CompareTag("Ball"))
            return;
        trigger = false;
    }
}
