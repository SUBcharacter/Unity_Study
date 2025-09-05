using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField] Item[] items;
    [SerializeField] int index;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach(Item i in items)
        {
            i.transform.gameObject.SetActive(false);
        }
        index = items.Length -1 ;
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Swap();
        }
        if(Input.GetMouseButtonDown(0))
        {
            items[index].Activate();
        }
    }

    void Swap()
    {
        items[index].transform.gameObject.SetActive(false);

        index = (index + 1) % items.Length;

        items[index].transform.gameObject.SetActive(true);
    }
}
