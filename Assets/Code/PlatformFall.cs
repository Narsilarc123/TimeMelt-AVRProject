using System.Collections;
using UnityEngine;

public class PlatformFall : MonoBehaviour
{
    public float delay = 0.5f;

    private Rigidbody rb;
    private bool hasFallen = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;   
    }

    public void TriggerFall()
    {
        if (hasFallen) return;

        hasFallen = true;
        Invoke(nameof(Fall), delay);
    }

    void Fall()
    {
        rb.isKinematic = false;
    }
}


