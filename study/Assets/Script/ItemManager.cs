using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField] GameObject[] gameObjects;
    
    int index = 0;
    int lastIndex = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach(GameObject go in gameObjects)
        {
            go.SetActive(false);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObjects[index].SetActive(true);

            lastIndex = index;

            index++;

            if(lastIndex != index)
            {
                gameObjects[lastIndex].SetActive(false);
            }

            if(index > 3)
            {
                index = 0;
            }
        }
    }
}
