using UnityEngine;
using UnityEngine.UI;


public class Selectable : MonoBehaviour
{
    Text text;

    private void Awake()
    {
        text = GetComponentInChildren<Text>();
    }

    public void Enter()
    {
        text.fontSize = 90;
    }

    public void Exit()
    {
        text.fontSize = 75;
    }

    public void Down()
    {
        text.fontSize = 50;
    }
}
