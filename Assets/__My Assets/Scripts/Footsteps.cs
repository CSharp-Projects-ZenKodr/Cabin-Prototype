using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public PhysicMaterial grassPhysMat;
    public List<AudioClip> grassClipSet; 
    public AudioSource mySource;


    // Update is called once per frame
    void OnCollisionStay(Collision collInfo)
    {
        if (collInfo.collider.material == grassPhysMat)
        {
            int toPlay = Random.Range(0, 10);
            mySource.PlayOneShot(grassClipSet[toPlay], 0.9F);
            mySource.Play();
        }
    }
}
