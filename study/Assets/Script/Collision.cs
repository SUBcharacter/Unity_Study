using UnityEngine;
using UnityEngine.Events;

public class Collision : MonoBehaviour
{
    [SerializeField] UnityEvent[] callBack;
    [SerializeField]Material[] material;
    MeshRenderer meshRenderer;
    Rigidbody rigid;

    private void Awake()
    { 
        rigid = GetComponent<Rigidbody>();
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        
    }

    private void OnCollisionExit(UnityEngine.Collision collision)
    {
        if (!collision.gameObject.CompareTag("Ball"))
            return;
        meshRenderer.material = material[0];
        if (callBack != null)
        {
            callBack[1].Invoke();
        }


    }

    private void OnCollisionStay(UnityEngine.Collision collision)
    {
        if (!collision.gameObject.CompareTag("Ball"))
            return;
        meshRenderer.material = material[1];
        if(callBack != null)
        {
            callBack[0].Invoke();
        }
    }
}
