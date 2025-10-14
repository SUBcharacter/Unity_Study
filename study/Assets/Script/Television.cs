using UnityEngine;
using UnityEngine.Video;

public class Television : MonoBehaviour
{
    [SerializeField] VideoClip[] clips;
    [SerializeField] VideoPlayer player;

    [SerializeField] int channel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        channel = PlayerPrefs.GetInt("Channel");
        player.clip = clips[channel];
    }

    public void NextChannel()
    {
        channel = (channel+1) % clips.Length;
        player.clip = clips[channel];
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
