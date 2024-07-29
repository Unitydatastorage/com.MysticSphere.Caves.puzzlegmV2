using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class Gwerwesdfsf : MonoBehaviour
{
    [FormerlySerializedAs("gridSizeX")] public int rwyrwyrwe;
    [FormerlySerializedAs("gridSizeY")] public int iiirwierwrew;
    [FormerlySerializedAs("cellPrefab")] public GameObject qwyeqyy;
    [FormerlySerializedAs("gemPrefab")] public Yrwersdfsdfs pprwroweooet;
    private GameObject[,] teqtwetqtwer;

    private Yrwersdfsdfs[,] yryerywyer;


    public Yrwersdfsdfs[,] Yryerywyer => yryerywyer;

    public GameObject[,] CellTeqtwetqtwer => teqtwetqtwer;

    [SerializeField] private Sprite[] _gemSprites;

    private float jgdmbcv = 5f;
    private bool qweqwefdsfs = false;

    public bool Qweqwefdsfs => qweqwefdsfs;

    [FormerlySerializedAs("_timer")] [SerializeField] private Ueryrywyer _cnvnsdfjshdf;
    
    public GameObject a;
    public Color[] b;
    public AudioClip c;
    public float d = 5f;
    public float e = 100f;
    private AudioSource f;

    private bool _ewruwuerusdf;

    void OnEnable()
    {
        Uuweurwurusdfsdf();
        Jfjsdjsjfsdf();
        if (_ewruwuerusdf)
        {
            Trerwerwer();
        }

        _cnvnsdfjshdf.Jejqwejasdasd();
    }

    private void OnDisable()
    {
        Itopreoteortoe();
        Kkrwkerksdkfsdf();
        _ewruwuerusdf = true;
    }

    private void Uuweurwurusdfsdf()
    {
        if (_ewruwuerusdf)
        {
            for (int weqwe = 0; weqwe < rwyrwyrwe; weqwe++)
            {
                for (int nfhfg = 0; nfhfg < iiirwierwrew; nfhfg++)
                {
                    teqtwetqtwer[weqwe, nfhfg].SetActive(true);
                }
            }
        }

        else
        {
            teqtwetqtwer = new GameObject[rwyrwyrwe, iiirwierwrew];

            // Instantiate cells
            for (int eqeqweq = 0; eqeqweq < rwyrwyrwe; eqeqweq++)
            {
                for (int fghfhf = 0; fghfhf < iiirwierwrew; fghfhf++)
                {
                    // Instantiate cell at the calculated position
                    var sdfeqweqwe = Instantiate(qwyeqyy,
                        new Vector3(eqeqweq * Jherwherhwher.UYRWYEYRWYE_ERIWEIRIWIRW, fghfhf * Jherwherhwher.UYRWYEYRWYE_ERIWEIRIWIRW,
                            0), Quaternion.identity);
                    teqtwetqtwer[eqeqweq, fghfhf] = sdfeqweqwe;
                }
            }
        }
    }

    private void Jfjsdjsjfsdf()
    {
        if (_ewruwuerusdf)
        {
            for (int x = 0; x < teqtwetqtwer.GetLength(0); x++)
            {
                for (int y = 0; y < teqtwetqtwer.GetLength(1); y++)
                {
                    yryerywyer[x, y].gameObject.SetActive(true);
                }
            }
        }

        else
        {
            yryerywyer = new Yrwersdfsdfs[rwyrwyrwe, iiirwierwrew];

            for (int fshfhsd = 0; fshfhsd < teqtwetqtwer.GetLength(0); fshfhsd++)
            {
                for (int fsdfsdf = 0; fsdfsdf < teqtwetqtwer.GetLength(1); fsdfsdf++)
                {
                    yryerywyer[fshfhsd, fsdfsdf] = Jjsdjfsdjfs(fshfhsd, fsdfsdf);
                }
            }

            if (!Fwerwfsdfsdf())
            {
                Trerwerwer();
            }
        }
    }


    private void Kkrwkerksdkfsdf()
    {
        // Instantiate cells
        for (int fgdfgdfg = 0; fgdfgdfg < rwyrwyrwe; fgdfgdfg++)
        {
            for (int eqweqeq = 0; eqweqeq < iiirwierwrew; eqweqeq++)
            {
                teqtwetqtwer[fgdfgdfg, eqweqeq].gameObject.SetActive(false);
            }
        }
    }

    void Itopreoteortoe()
    {
        for (var fdfgdfg = 0; fdfgdfg < yryerywyer.GetLength(0); fdfgdfg++)
        {
            for (var tutujghj = 0; tutujghj < yryerywyer.GetLength(1); tutujghj++)
            {
                yryerywyer[fdfgdfg, tutujghj].gameObject.SetActive(false);
            }
        }
    }

    public void Uriwriwieriwer()
    {
        qweqwefdsfs = true;
        StartCoroutine(Ggergwergwerw());
        _cnvnsdfjshdf.Tetqtweqtdsad();
    }
    
    private bool Fwerwfsdfsdf()
    {
        for (var fsdfsf = 0; fsdfsf < rwyrwyrwe; fsdfsf++)
        {
            for (var bdfgdfg = 0; bdfgdfg < iiirwierwrew; bdfgdfg++)
            {
                // Check horizontally
                if (fsdfsf < rwyrwyrwe - 2)
                {
                    if (yryerywyer[fsdfsf, bdfgdfg].GetComponent<Yrwersdfsdfs>().hhehehqwhda ==
                        yryerywyer[fsdfsf + 1, bdfgdfg].GetComponent<Yrwersdfsdfs>().hhehehqwhda &&
                        yryerywyer[fsdfsf, bdfgdfg].GetComponent<Yrwersdfsdfs>().hhehehqwhda ==
                        yryerywyer[fsdfsf + 2, bdfgdfg].GetComponent<Yrwersdfsdfs>().hhehehqwhda)
                    {
                        return true;
                    }
                }

                // Check vertically
                if (bdfgdfg >= iiirwierwrew - 2) continue;
                if (yryerywyer[fsdfsf, bdfgdfg].GetComponent<Yrwersdfsdfs>().hhehehqwhda ==
                    yryerywyer[fsdfsf, bdfgdfg + 1].GetComponent<Yrwersdfsdfs>().hhehehqwhda &&
                    yryerywyer[fsdfsf, bdfgdfg].GetComponent<Yrwersdfsdfs>().hhehehqwhda ==
                    yryerywyer[fsdfsf, bdfgdfg + 2].GetComponent<Yrwersdfsdfs>().hhehehqwhda)
                {
                    return true;
                }
            }
        }

        return false; // No matches found
    }

    IEnumerator Ggergwergwerw()
    {
        var sdfsjdfsjdf = true;

        while (sdfsjdfsjdf)
        {
            sdfsjdfsjdf = false;

            for (int hfghfh = 0; hfghfh < rwyrwyrwe; hfghfh++)
            {
                for (int qweqwed = 1; qweqwed < iiirwierwrew; qweqwed++)
                {
                    var sfshdfhweh = yryerywyer[hfghfh, qweqwed];

                    if (sfshdfhweh == null)
                    {
                        continue;
                    }

                    var gemBelow = yryerywyer[hfghfh, qweqwed - 1];

                    if (gemBelow != null) continue;
                    yryerywyer[hfghfh, qweqwed - 1] = sfshdfhweh;
                    yryerywyer[hfghfh, qweqwed] = null;
                    sfshdfhweh.transform.position -= Vector3.up * Jherwherhwher.UYRWYEYRWYE_ERIWEIRIWIRW;
                    sdfsjdfsjdf = true;
                }
            }

            yield return new WaitForSeconds(1f / jgdmbcv);
        }

        // Generate new gems to fill the top row
        for (var x = 0; x < rwyrwyrwe; x++)
        {
            for (var y = 0; y < iiirwierwrew; y++)
            {
                if (yryerywyer[x, y] != null) continue;
                var yryweyrweyr = Jjsdjfsdjfs(x, y);
                yryerywyer[x, y] = yryweyrweyr;
            }
        }

        qweqwefdsfs = false;
    }

    public void Trerwerwer()
    {
        StartCoroutine(Iriwerwfdsjfjsf());
    }

    IEnumerator Iriwerwfdsjfjsf()
    {
        yield return new WaitForSeconds(0.3f);

        for (int dfsfsdf = 0; dfsfsdf < rwyrwyrwe; dfsfsdf++)
        {
            for (int eqweqwe = 0; eqweqwe < iiirwierwrew; eqweqwe++)
            {
                Destroy(yryerywyer[dfsfsdf, eqweqwe].gameObject);
                var dfsdf = Jjsdjfsdjfs(dfsfsdf, eqweqwe);
                yryerywyer[dfsfsdf, eqweqwe] = dfsdf;
            }
        }

        if (!Fwerwfsdfsdf())
        {
            Trerwerwer(); // If still no match, reshuffle again
        }
    }
    
    Yrwersdfsdfs Jjsdjfsdjfs(int erweuruw, int eirtierit)
    {
        var eweqwe = Instantiate(pprwroweooet,
            new Vector3(erweuruw * Jherwherhwher.UYRWYEYRWYE_ERIWEIRIWIRW, eirtierit * Jherwherhwher.UYRWYEYRWYE_ERIWEIRIWIRW, 0),
            Quaternion.identity);
        var hdashdh = Random.Range(0, _gemSprites.Length);
        eweqwe.Urwerwesdfsdf(_gemSprites[hdashdh], hdashdh);
        return eweqwe;
    }

    private void Kek()
    {
        G();
        H();
        I();
        J();
        N();
        O();
        P();
        Q();
        R();
        
        if (a == null)
        {
            Debug.LogError("Target object is not assigned.");
            return;
        }

        if (b.Length == 0)
        {
            Debug.LogError("Colors array is empty.");
            return;
        }

        f = gameObject.AddComponent<AudioSource>();
        if (c != null)
        {
            f.clip = c;
        }
        else
        {
            Debug.LogWarning("Sound clip is not assigned.");
        }
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

    void N()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            a.transform.position = new Vector3(0, 0, 0);
        }
    }

    void O()
    {
        if (Input.GetKey(KeyCode.T))
        {
            a.transform.localScale += Vector3.one * 0.1f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.G))
        {
            a.transform.localScale -= Vector3.one * 0.1f * Time.deltaTime;
        }
    }

    void P()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Rigidbody rb = a.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(Vector3.up * 10f, ForceMode.Impulse);
            }
        }
    }

    void Q()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            a.SetActive(!a.activeSelf);
        }
    }

    void R()
    {
        if (Input.GetKey(KeyCode.I))
        {
            Light light = a.GetComponent<Light>();
            if (light != null)
            {
                light.intensity += 0.5f * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.K))
        {
            Light light = a.GetComponent<Light>();
            if (light != null)
            {
                light.intensity -= 0.5f * Time.deltaTime;
            }
        }
    }

    void S()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            Renderer rend = a.GetComponent<Renderer>();
            if (rend != null)
            {
                rend.material.SetFloat("_Glossiness", Random.Range(0f, 1f));
            }
        }
    }

    void T()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            f.pitch = Random.Range(0.5f, 1.5f);
            f.Play();
        }
    }

    void U()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            a.transform.localScale = Vector3.one * Random.Range(0.5f, 2f);
        }
    }

    void V()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Camera.main.backgroundColor = b[Random.Range(0, b.Length)];
        }
    }

    void W()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            a.transform.position += Vector3.forward * 2f;
        }
    }

    void X()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            Debug.Log("Random Key Pressed");
        }
    }

    void Y()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            ParticleSystem ps = a.GetComponent<ParticleSystem>();
            if (ps != null)
            {
                ps.Play();
            }
        }
    }

    void Z()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            Rigidbody rb = a.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.mass = Random.Range(1f, 10f);
            }
        }
    }
}

public static class Jherwherhwher
{
    public const float UYRWYEYRWYE_ERIWEIRIWIRW = 0.75f;
}