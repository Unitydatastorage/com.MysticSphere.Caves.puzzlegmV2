using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Irwersdfsdfsf : MonoBehaviour
{
   public GameObject obj;
    public Material[] mats;
    public AudioClip jSound;
    public float jForce = 5f;
    public float rSpeed = 50f;
    public float sSpeed = 0.05f;
    public Light sLight;
    private AudioSource aSrc;
    private Rigidbody tRb;
    private bool g;

    void Start()
    {
        if (obj == null)
        {
            Debug.LogError("Object is not assigned.");
            return;
        }

        if (mats.Length == 0)
        {
            Debug.LogError("Materials array is empty.");
            return;
        }

        aSrc = gameObject.AddComponent<AudioSource>();
        if (jSound != null)
        {
            aSrc.clip = jSound;
        }
        else
        {
            Debug.LogWarning("Jump sound is not assigned.");
        }

        tRb = obj.AddComponent<Rigidbody>();
        tRb.useGravity = true;

        if (sLight == null)
        {
            Debug.LogWarning("Scene light is not assigned.");
        }

        g = true;
    }

    void Update()
    {
        JumpObj();
        RotateObj();
        ScaleObj();
        ChangeMatOnKey();
        ToggleLightOnKey();
    }

    void JumpObj()
    {
        if (Input.GetKeyDown(KeyCode.Space) && g)
        {
            tRb.AddForce(Vector3.up * jForce, ForceMode.Impulse);
            aSrc.Play();
            g = false;
        }
    }

    void RotateObj()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            obj.transform.Rotate(Vector3.up, -rSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            obj.transform.Rotate(Vector3.up, rSpeed * Time.deltaTime);
        }
    }

    void ScaleObj()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            obj.transform.localScale += Vector3.one * sSpeed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            obj.transform.localScale -= Vector3.one * sSpeed;
        }
    }

    void ChangeMatOnKey()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            ChangeMat();
        }
    }

    void ChangeMat()
    {
        if (mats.Length > 0)
        {
            Material nMat = mats[Random.Range(0, mats.Length)];
            Renderer rend = obj.GetComponent<Renderer>();
            if (rend != null)
            {
                rend.material = nMat;
            }
        }
    }

    void ToggleLightOnKey()
    {
        if (Input.GetKeyDown(KeyCode.L) && sLight != null)
        {
            sLight.enabled = !sLight.enabled;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            g = true;
        }
    }
}
