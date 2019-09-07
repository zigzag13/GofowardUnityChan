using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

    private float speed = -0.2f;

    private float deadLine = -10;

    public AudioClip audio1;

    private AudioSource audioSource;

	// Use this for initialization
	void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(this.speed, 0, 0);

        if(transform.position.x < this.deadLine)
        {
            Destroy(this.gameObject);
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "UnityChan2D")
        {

        }

        else
        { 
            audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.clip = audio1;
            audioSource.Play();
        }
    }
}
