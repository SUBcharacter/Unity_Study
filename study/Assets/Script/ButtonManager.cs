using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] Button[] buttonList;

    public void Execute()
    {
        Debug.Log("Execute");
    }

    public void Option()
    {
        Debug.Log("Option");
    }

    public void Quit()
    {
        Debug.Log("Quit");
    }

}
