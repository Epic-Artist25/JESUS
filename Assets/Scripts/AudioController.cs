using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{

    public AudioSource Jato;
    public AudioClip[] audios;
    public AudioMixer mixer;


    public Slider effSl, audioSl;

    public void PlayAudio(int indice)
    {
        Jato.clip = audios[indice];
        Jato.Play();
    }

    public void MudarVolume(int indice)
    {
        if (indice == 0)
        {
            mixer.SetFloat("volvol", audioSl.value);
        }
        if (indice == 1)
        {
            mixer.SetFloat("efvol", effSl.value);
        }

    }

}