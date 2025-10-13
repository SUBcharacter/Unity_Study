using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] Ray ray;
    [SerializeField] float maxDistance = 100.0f;
    [SerializeField] LayerMask layer;
    [SerializeField] Color color = Color.red;
    [SerializeField] RaycastHit hit;
    bool isHit = false;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            Debug.DrawRay(ray.origin, ray.direction * maxDistance, color,10f);
            if (Physics.Raycast(ray, out hit, maxDistance,layer))
            {
                hit.collider.GetComponentInParent<HPBar>().Damage(3);
                
                Debug.Log(hit.collider.name);

            }
        }

        
    }
}
