using System.Runtime.CompilerServices;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class AudioController : MonoBehaviour
{
    [SerializeField]
    AudioClip trackingFound;

    [SerializeField]
    AudioClip trackingLost;

    AudioSource audiosource;


    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    public void PlayonFound()
    {
        audiosource.PlayOneShot(trackingFound);
    }
    
    public void PlayonLost()
    {
        audiosource.PlayOneShot(trackingLost);
    }


}    