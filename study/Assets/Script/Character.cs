using UnityEngine;

[RequireComponent (typeof(Move))]
public class Character : MonoBehaviour
{
    [SerializeField]Move move;

    private void Awake()
    {
        move = GetComponent<Move>();
        
    }
    private void Start()
    {
        Debug.Log(transform.position);
    }

    private void Update()
    {
        // Time.deltaTime
        // 마지막 프레임 이후의 완료되는 시간
    }

    private void FixedUpdate()
    {
        move.OnMove(new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")));
    }
}

