using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpJP : MonoBehaviour
{
    public float moveSpeed;
    public float destroyDelay;
    private AudioSource audioSource;
    public AudioClip ghostNoise;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(ghostNoise);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);
        StartCoroutine(DestroyGhost());
        
    }

    IEnumerator DestroyGhost()
    {
        yield return new WaitForSeconds(destroyDelay);
        Destroy(gameObject);
    }
}
