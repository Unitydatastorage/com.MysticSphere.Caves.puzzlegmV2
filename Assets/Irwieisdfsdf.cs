using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Irwieisdfsdf : MonoBehaviour
{

    public GameObject _fkfjsfdjwejr;
    private bool _herhwqehsdfs = true;

    private Button _weyrwyerysdf;

    public bool Grwerwefsdfsf
    {
        get => _herhwqehsdfs;
        set => _herhwqehsdfs = value;
    }
    
    
    public delegate void Hrwersdfsdfsdf(int buttonIndex);
    
    public event Hrwersdfsdfsdf Oroweorsdfsdf;

    private void Start()
    {
        _weyrwyerysdf = GetComponent<Button>();
        _weyrwyerysdf.onClick.AddListener(Urwerywyefsdf);
    }

    public bool Uewqerfsdfsdf(int oowssdfsdrfwer)
    {
        var sasdwqeqwe = _fkfjsfdjwejr.GetComponent<TMP_Text>().text;
        var rewerfw = Int32.Parse(sasdwqeqwe) - 1;
        return oowssdfsdrfwer == rewerfw;
    }

    public void Wrfwersdfsdfsdfs()
    {
        _herhwqehsdfs = false;
        if (_weyrwyerysdf == null)
        {
            _weyrwyerysdf = GetComponent<Button>();
        }
        _weyrwyerysdf.interactable = true;
    }

    private void Urwerywyefsdf()
    {
        if (Oroweorsdfsdf == null) return;
        var fgdgererte = _fkfjsfdjwejr.GetComponent<TMP_Text>().text;
        var fghfter = Int32.Parse(fgdgererte);
        Oroweorsdfsdf(fghfter);
    }
}
