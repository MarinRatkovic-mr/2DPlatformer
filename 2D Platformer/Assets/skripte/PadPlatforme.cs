using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadPlatforme : MonoBehaviour
{
    public float fallDelay = 1f;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Invoke("Fall", fallDelay);
        }
    }
    void Fall()
    {
        rb2d.isKinematic = false;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
