using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager soumana;
    public AudioClip adcl;

    private void Awake()
    {
        if (soumana == null)
        {
            soumana = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

}