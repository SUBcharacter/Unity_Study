using UnityEngine;
using UnityEngine.UI;

public class HomeButton : MonoBehaviour
{
    [SerializeField]Button button;
    [SerializeField]SceneryManager sceneryManager;

    private void Awake()
    {
        button = GetComponent<Button>();
        sceneryManager = FindAnyObjectByType<SceneryManager>();
    }

    private void Start()
    {
        button.onClick.AddListener(() => sceneryManager.SceneMove(0));
    }

}
