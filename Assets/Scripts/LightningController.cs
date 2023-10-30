using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningController : MonoBehaviour
{
    public Light light;
    private float delay;

    public float minDelay;
    public float maxDelay;

    private bool canStrike = true;

    public AudioSource audioSource;
    public AudioClip thunder;




    // Start is called before the first frame update
    void Start()
    {
        //light = GetComponent<Light>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canStrike)
        {
            delay = Random.Range(minDelay,maxDelay);
            StartCoroutine(LightningStrike());

        }
    }

    IEnumerator LightningStrike()
    {
        canStrike = false;
        yield return new WaitForSeconds(delay);

        light.enabled = true;
        yield return new WaitForSeconds(0.25f);
        audioSource.PlayOneShot(thunder);
        light.enabled = false;

        canStrike = true;
    }
}
