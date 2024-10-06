using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class OnButtonMachine : MonoBehaviour
{
    public bool isOn = false;
    public AudioSource audioSource; // Reference to the AudioSource component
    public AudioClip audioClip;     // Reference to the audio clip to be played

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<XRSimpleInteractable>().selectEntered.AddListener(PlayAudio);
    }


    // Method to play the audio
    public void PlayAudio(SelectEnterEventArgs args)
    {
        if (audioSource != null && audioClip != null)
        {
            audioSource.clip = audioClip;
            audioSource.Play();
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
