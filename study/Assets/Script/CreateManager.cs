using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject[] prefaps;
    [SerializeField] List<GameObject> pools;

    public float time = 5.0f;
    public int index = 0;
    private void Start()
    {
        init();
        StartCoroutine(Coroutine());
    }

    void init()
    {
        pools.Capacity = 10;

        for (int i = 0; i < prefaps.Length; i++)
        {
            float x = i * 2.0f;

            pools.Add(Instantiate(prefaps[i], gameObject.transform));
            pools[i].transform.position = new Vector3(x, 0, 0);
            if (i % 2 == 1)
            {
                pools[i].SetActive(true);
            }
            else
                pools[i].SetActive(false);
            

        }
    }

    private void Update()
    {
        
    }

    IEnumerator Coroutine()
    {
        Debug.Log("진입");

        while (true)
        {
            int exit = 0;
            
            for (int i = 0; i<pools.Count; i++)
            {
                if (pools[i].activeSelf)
                {
                    exit++;
                }
            }
            if (exit >= pools.Count)
            {
                break;
            }
            Debug.Log($"현재 활성화 수 : {exit}");

            index = Random.Range(0, pools.Count);

            while (pools[index].activeSelf)
            {
                index = Random.Range(0, pools.Count);
            }
            yield return new WaitForSeconds(5f); 

            pools[index].SetActive(true);

        }


        while(true)
        {
            int exit = 0;
            for(int i = 0; i< pools.Count; i++)
            {
                if(!pools[i].activeSelf)
                {
                    exit++;
                }
            }
            if (exit >= pools.Count)
            {
                yield break;
            }
            Debug.Log($"현재 비활성화 수 : {exit}");
            index = Random.Range(0,pools.Count);
            
            while(!pools[index].activeSelf)
            {
                index = Random.Range(0,pools.Count);
            }
            yield return new WaitForSeconds(5f);

            pools[index].SetActive(false);

            yield return StartCoroutine(Coroutine());
        }

        
    }
}
