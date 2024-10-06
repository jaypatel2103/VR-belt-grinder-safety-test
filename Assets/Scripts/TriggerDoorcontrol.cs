using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorcontrol : MonoBehaviour
{
    // Reference to the Animator component of the door
    [SerializeField] private Animator doorAnimator;
    
    // The name of the boolean parameter in the Animator that controls the door
    private string doorOpenParameterName = "isOpen";

    // When the player enters the trigger area
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Set the Animator parameter to true to open the door
            doorAnimator.SetBool(doorOpenParameterName, true);
        }
    }

    // When the player exits the trigger area
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Set the Animator parameter to false to close the door
            doorAnimator.SetBool(doorOpenParameterName, false);
        }
    }
}
