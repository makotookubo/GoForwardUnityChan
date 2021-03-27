using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collisition)
    {
        if (collisition.gameObject.tag == "CubeTag" || collisition.gameObject.tag == "GroundTag")
        {
            audioSource.clip = sound1;
            audioSource.Play();
            Debug.Log("おはよう");
        }
    }

}
