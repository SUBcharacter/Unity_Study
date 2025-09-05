using UnityEngine;

public class Unleathal : Item
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public override void Activate()
    {
        Debug.Log("비살상 장비 작동");
    }
}
