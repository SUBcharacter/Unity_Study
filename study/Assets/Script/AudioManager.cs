using System.Threading.Tasks;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] static AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        audioSource.Play();
    }

    public static void Emit(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

    public static void Create(AudioClip clip, Transform point)
    {
        AudioSource.PlayClipAtPoint(clip, point.position);
    }

}
