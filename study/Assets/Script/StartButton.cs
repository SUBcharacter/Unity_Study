using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    [SerializeField] Button button;
    [SerializeField] SceneryManager sceneryManager;

    private void Awake()
    {
        button = GetComponent<Button>();
        sceneryManager = FindAnyObjectByType<SceneryManager>();
    }

    private void Start()
    {
        if(sceneryManager != null)
        {
            Debug.Log("DD");

            sceneryManager = FindAnyObjectByType<SceneryManager>();
        }
        button.onClick.AddListener(() => sceneryManager.SceneMove(1));
    }
}
