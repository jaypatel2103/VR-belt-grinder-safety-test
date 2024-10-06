using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineAnimation : MonoBehaviour
{ 
    public Animator playerAnimator;
    public GameObject beforeknife;
    // This method is called when another collider enters the trigger collider attached to the GameObject
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {

            // Log result to the console
            if (!beforeknife.activeInHierarchy)
            {
                return;
            }
            else
            {
                playerAnimator.SetBool("isGrinding", true);
            }
        }
    }

   
}
