using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization;


public class KnifeGrinding : MonoBehaviour
{
    public GameObject after;
    public GameObject before;
    public ParticleSystem ps;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("knife"))
        {
            ps.Play();
            StartCoroutine(WaitAndSwapObjects());
        }
    }

    private IEnumerator WaitAndSwapObjects()
    {
        // Wait for 2 seconds
        yield return new WaitForSeconds(3f);

        // Activate the 'after' object and deactivate the 'before' object
        after.SetActive(true);
        

        before.SetActive(false);
        ps.Stop();
        GameManger.Instance.Finish();
    }

}
