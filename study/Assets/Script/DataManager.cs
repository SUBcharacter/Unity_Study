using UnityEngine;
using UnityEngine.Rendering;

public class DataManager : MonoBehaviour
{
    [SerializeField] int channel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerPrefs.SetInt("Channel", channel);
        
        PlayerPrefs.Save();
    }

    public void Save()
    {
        PlayerPrefs.Save();
    }

    public void UpdateChannel()
    {
        PlayerPrefs.SetInt("Channel", channel);
        Save();
    }

    public void Delete()
    {
        PlayerPrefs.DeleteAll();
    }
}
