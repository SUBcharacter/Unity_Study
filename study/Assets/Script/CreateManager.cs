using System.Collections.Generic;
using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject[] prefaps;
    [SerializeField] List<GameObject> pools;

    float time = 5.0f;
    int index = 0;
    private void Start()
    {
        init();
    }

    void init()
    {
        pools.Capacity = 10;

        for (int i = 0; i < prefaps.Length; i++)
        {
            float x = i * 2.0f;

            pools.Add(Instantiate(prefaps[i], gameObject.transform));
            pools[i].transform.position = new Vector3(x, 0, 0);
            pools[i].SetActive(false);

        }
    }

    private void Update()
    {
        time -= Time.deltaTime;

        if(time <=0)
        {
            pools[index].SetActive(!pools[index].activeSelf);
            index = (index + 1) % pools.Count;
            time = 5.0f;
        }

    }
}
