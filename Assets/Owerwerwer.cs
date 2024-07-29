using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Serialization;

public class Owerwerwer : MonoBehaviour
{
    [FormerlySerializedAs("cellLayer")] public LayerMask djfasjdasj;
    [FormerlySerializedAs("minSwipeDistance")] public float eiqweii = 1f;

    private Vector2 eoeqweasd;
    private Vector2 kghkdgkdfg;
    private List<GameObject> wetqetase = new List<GameObject>();
    private List<Yrwersdfsdfs> mfmsdfjjv = new List<Yrwersdfsdfs>();

    private bool qweasdtasd = false;

    [FormerlySerializedAs("_sprite")] [SerializeField] private Sprite _yotyorofgdfg;
    [FormerlySerializedAs("_defaultSprite")] [SerializeField] private Sprite _nvnsdnfsndf;
    [FormerlySerializedAs("_wrongSprite")] [SerializeField] private Sprite _xvzcvvsdasd;
    
    [FormerlySerializedAs("rayLength")] public float jlghljglfhg = 1f;
    [FormerlySerializedAs("rayCount")] public int weurwuruwt = 10;
    [FormerlySerializedAs("raySpacing")] public float erwerqwreqe = 0.1f;

    private List<GameObject> weiriweirfs = new List<GameObject>();


    private GameObject _cvxvbxbvsdf;

    [FormerlySerializedAs("grid")] [SerializeField] private Gwerwesdfsf _tiertiei;

    private Nbsfbsdwehrw _kwekrkwkfsdf;
    private GameObject _qweqeasdasd;
    private GameObject _cvmvxmcvnxvdf;
    private bool _tkerktkefkgdfg;
    
    
    private bool _rjwerjsdjfs = false;

    [FormerlySerializedAs("_isBlocked")] public bool _bckvbcgkdfg;

    public bool Bckvbcgkdfg => _bckvbcgkdfg;

    [FormerlySerializedAs("_score")] [SerializeField] private Irwersdfsdf irwersdfsdf;
    [FormerlySerializedAs("audioControl")] [SerializeField] private Jtetewrwer _dfgkdfgkdkg;
    
    [FormerlySerializedAs("_soundWin")] [SerializeField] private AudioClip _ieriwirsdfs;
    [FormerlySerializedAs("_soundLose")] [SerializeField] private AudioClip _vbnmcvnbcnb;

    [FormerlySerializedAs("_soundPass")] [SerializeField] private AudioClip _eiqweiasidasid;
    

    private void OnEnable()
    {
        mfmsdfjjv = new List<Yrwersdfsdfs>();
        wetqetase = new List<GameObject>();

        if (_tiertiei.CellTeqtwetqtwer != null)
        {
            foreach (var cell in _tiertiei.CellTeqtwetqtwer)
            {
                cell.GetComponent<SpriteRenderer>().sprite = _nvnsdnfsndf;
            }
        }

        qweasdtasd = false;
        _rjwerjsdjfs = false;
        _bckvbcgkdfg = false;
        _tkerktkefkgdfg = false;
        _cvmvxmcvnxvdf = null;
        _qweqeasdasd = null;

    }

    private void OnDisable()
    {
        mfmsdfjjv.Clear();
        wetqetase.Clear();
    }

    private void Update()
    {
        if (_bckvbcgkdfg || _tiertiei.Qweqwefdsfs)
        {
            return;
        }

        if (!_tiertiei.enabled)
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            // Clear previous selection when starting a new selection
            qweasdtasd = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            qweasdtasd = false;
            _tkerktkefkgdfg = false;
            _cvmvxmcvnxvdf = null;
            _qweqeasdasd = null;
            _kwekrkwkfsdf = Nbsfbsdwehrw.None;
            Uerwerwfsdfsdf();
        }
        
        if (qweasdtasd)
        {
            // During drag, perform raycast and update selection
            Hfsrwersfsrwer();
        }
    }
    
    void Hfsrwersfsrwer()
    {
        Vector2 uyeuteurtuer = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Calculate start direction based on mouse movement
        var dfhghewhrwe = (Vector2)Input.mousePosition - uyeuteurtuer;
        dfhghewhrwe.Normalize();

        // Calculate perpendicular direction for "snake" pattern
        var fsdfwerwfsd = new Vector2(-dfhghewhrwe.y, dfhghewhrwe.x);

        for (var i = 0; i < weurwuruwt; i++)
        {
            // Calculate offset for current ray
            var fsdfsdfew = (i - (weurwuruwt - 1) / 2f) * erwerqwreqe;

            // Calculate direction for current ray
            var ytriyirtiy = dfhghewhrwe + fsdfsdfew * fsdfwerwfsd;

            // Perform raycast
            var hit = Physics2D.Raycast(uyeuteurtuer, ytriyirtiy, jlghljglfhg, djfasjdasj);

            if (hit.collider == null) continue;
            //if (_previousCollider != null)
            var fwerwew = hit.collider.gameObject;

            if (fwerwew == null)
            {
                return;
            }

            var iertieitg = fwerwew.transform.localPosition;
            var ityriyri = _tiertiei.Yryerywyer[(int)(iertieitg.x / Jherwherhwher.UYRWYEYRWYE_ERIWEIRIWIRW), (int)(iertieitg.y / Jherwherhwher.UYRWYEYRWYE_ERIWEIRIWIRW)];
            var etqwet = ityriyri.hhehehqwhda;

            if (qweasdtasd && !_tkerktkefkgdfg)
            {
                _qweqeasdasd = fwerwew;
                _kwekrkwkfsdf = etqwet;
                _tkerktkefkgdfg = true;
            }

            if (_cvmvxmcvnxvdf != null)
            {
                var ffsdfsjd = _cvmvxmcvnxvdf.transform.localPosition;
                var toyortoetert = Mathf.Abs(iertieitg.x - ffsdfsjd.x) + Mathf.Abs(iertieitg.y - ffsdfsjd.y) > 1;

                if (toyortoetert)
                {
                    return;
                }
            }

            if (_kwekrkwkfsdf != Nbsfbsdwehrw.None && _kwekrkwkfsdf != etqwet)
            {
                return;
            }
                
            // Add hit cell to selected cells if not already selected
            if (!wetqetase.Contains(fwerwew))
            {
                wetqetase.Add(fwerwew);
                mfmsdfjjv.Add(ityriyri);

                Prowerosdofsdf(fwerwew);
                _cvmvxmcvnxvdf = fwerwew;
            }

            if (_cvxvbxbvsdf != fwerwew)
            {
                _cvxvbxbvsdf = fwerwew;
            }
        }
    }

    void Prowerosdofsdf(GameObject iyuirtyr)
    {
        // Implement your own logic to highlight the selected cell
        // For example, you can change its color or scale
        iyuirtyr.GetComponent<SpriteRenderer>().sprite = _yotyorofgdfg;
    }


    IEnumerator Jjrjwjerwjerw()
    {
        _bckvbcgkdfg = true;
        yield return new WaitForSeconds(0.5f);
        Lfsjfjerjwersf();
        _bckvbcgkdfg = false;

    }

    public void Teqwedfasfer(bool fsdfwerw)
    {
        _bckvbcgkdfg = fsdfwerw;
    }

    public void Erewsdfgdfg()
    {
        _bckvbcgkdfg = true;
        _tiertiei.Trerwerwer();
        _bckvbcgkdfg = false;
    }
    
    void Lfsjfjerjwersf()
    {
        if (wetqetase == null) return;
        foreach (GameObject sdfswerwer in wetqetase)
        {
            // Reset cell to its original state (you can implement your own reset mechanism)
            sdfswerwer.GetComponent<SpriteRenderer>().sprite = _nvnsdnfsndf;
        }
        wetqetase.Clear();
        mfmsdfjjv?.Clear();
    }

    public void Cgdfgdterter()
    {
        _dfgkdfgkdkg.Kjhfgjhfje(_vbnmcvnbcnb);
    }
    
    void Uerwerwfsdfsdf()
    {
        var fjgdjgjerte = false;

        if (wetqetase.Count == 0)
        {
            return;
        }
        
        if (wetqetase.Count < 3)
        {

            foreach (GameObject eewqe in wetqetase)
            {
                // Reset cell to its original state (you can implement your own reset mechanism)
                eewqe.GetComponent<SpriteRenderer>().sprite = _xvzcvvsdasd;
            }
            Debug.Log(wetqetase.Count);
        }
        else
        {
            _dfgkdfgkdkg.Kjhfgjhfje(_eiqweiasidasid);

            for (int i = 0; i < mfmsdfjjv.Count; i++)
            {
                DestroyImmediate(mfmsdfjjv[i].gameObject);
                mfmsdfjjv[i] = null;
            }
            fjgdjgjerte = irwersdfsdf.Prwersdfsdf(mfmsdfjjv.Count);
            _tiertiei.Uriwriwieriwer();
        }
        
        StartCoroutine(Jjrjwjerwjerw());

        if (!fjgdjgjerte) return;
        _dfgkdfgkdkg.Kjhfgjhfje(_ieriwirsdfs);
        StopAllCoroutines();
        Lfsjfjerjwersf();
        _bckvbcgkdfg = true;
    }
}
