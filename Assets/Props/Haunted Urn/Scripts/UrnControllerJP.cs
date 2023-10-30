using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UrnControllerJP : MonoBehaviour
{
    public GameObject lid;
    public GameObject ghost;

    public float launchForce;
    public float knockback;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Summon Ghost
            Instantiate(ghost, transform.position, transform.rotation);

            //Launch the lid up
            lid.GetComponent<Rigidbody>().AddForce(Vector3.up * launchForce, ForceMode.Impulse);

            //Launch the player backwards
            collision.gameObject.GetComponent<Rigidbody>().AddRelativeForce(Vector3.back * knockback, ForceMode.Impulse);

        }
    }
}
