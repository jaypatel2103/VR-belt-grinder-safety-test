using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CloseButtonMachine : MonoBehaviour
{
    public AudioSource audioSource; // Reference to the AudioSource component

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<XRSimpleInteractable>().selectEntered.AddListener(StopAudio);
    }

    // Method to stop the audio
    public void StopAudio(SelectEnterEventArgs args)
    {
        if (audioSource != null)
        {
            audioSource.Stop();
        }
    }
    public void StopMachineAudio()
    {
        if (audioSource != null)
        {
            audioSource.Stop();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
