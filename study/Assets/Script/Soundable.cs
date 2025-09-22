using UnityEngine;

public class Soundable : MonoBehaviour
{
    [SerializeField] public AudioClip audioClip;


    private void Start()
    {
        AudioManager.Create(audioClip,transform);
    }
}
