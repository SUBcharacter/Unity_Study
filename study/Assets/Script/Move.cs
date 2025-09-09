using UnityEngine;

public class Move : Character
{
    [SerializeField] float speed = 10;
    [SerializeField] Vector3 direction;

    public void OnMove(Vector3 dir)
    {
        direction = dir;
        direction.Normalize();
        transform.position += dir * speed * Time.deltaTime;
    }
}
