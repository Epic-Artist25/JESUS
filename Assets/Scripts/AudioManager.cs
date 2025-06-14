using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioSource sfxSource;
    public AudioSource musicSource;
    public AudioClip[] audios;
    public AudioMixer mixer;
    public Slider masterSlider, musicSlider, sfxSlider;

    private void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            LoadVolume();
        }
        else
        {
            SetMasterVolume();
            SetMusicVolume();
            SetSFXVolume();
        }
        //SetMasterVolume();
        //SetMusicVolume();
        //SetSFXVolume();
        /*musicSource.clip = audios[0];
        musicSource.Play();*/
    }
    public void PlayAudio(int index)
    {
        sfxSource.clip = audios[index];
        sfxSource.Play();
    }
    public void SetMasterVolume()
    {
        mixer.SetFloat("Master", Mathf.Log10(masterSlider.value) * 20);
        PlayerPrefs.SetFloat("masterVolume", masterSlider.value);
    }
    public void SetMusicVolume()
    {
        mixer.SetFloat("Musica", Mathf.Log10(musicSlider.value) * 20);
        PlayerPrefs.SetFloat("musicVolume", musicSlider.value);
    }

    public void SetSFXVolume()
    {
        mixer.SetFloat("SFX", Mathf.Log10(sfxSlider.value) * 20);
        PlayerPrefs.SetFloat("SFXVolume", musicSlider.value);
    }

    private void LoadVolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("masterVolume");
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
        sfxSlider.value = PlayerPrefs.GetFloat("SFXVolume");
        SetMusicVolume();
        SetSFXVolume();
    }

}