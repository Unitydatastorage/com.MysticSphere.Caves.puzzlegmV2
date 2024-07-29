using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kriweiriw : MonoBehaviour
{
    public GameObject a;
    public Color[] b;
    public AudioClip c;
    public float d = 5f;
    public float e = 100f;
    private AudioSource f;

    void Start()
    {
        if (a == null)
        {
            Debug.LogError("Urwerwfsdfsf");
            return;
        }

        if (b.Length == 0)
        {
            Debug.LogError("Jrweruwuerw.");
            return;
        }

        f = gameObject.AddComponent<AudioSource>();
        if (c != null)
        {
            f.clip = c;
        }
        else
        {
            Debug.LogWarning("Irieirwiriwifsdf.");
        }
    }

    void Update()
    {
        G();
        H();
        I();
        J();
    }

    void G()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 k = new Vector3(h, 0, v);
        a.transform.Translate(k * d * Time.deltaTime);
    }

    void H()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            a.transform.Rotate(Vector3.up, -e * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            a.transform.Rotate(Vector3.up, e * Time.deltaTime);
        }
    }

    void I()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            L();
        }
    }

    void L()
    {
        if (b.Length > 0)
        {
            Color m = b[Random.Range(0, b.Length)];
            Renderer n = a.GetComponent<Renderer>();
            if (n != null)
            {
                n.material.color = m;
            }
        }
    }

    void J()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            M();
        }
    }

    void M()
    {
        if (f != null && c != null)
        {
            f.Play();
        }
    }
}
