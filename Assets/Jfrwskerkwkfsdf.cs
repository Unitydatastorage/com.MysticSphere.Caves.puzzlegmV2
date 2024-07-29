using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Jfrwskerkwkfsdf : MonoBehaviour
{

    private void Start()
    {
        Ueqeqdasdasd();
    }

    [FormerlySerializedAs("_levels")] [SerializeField] private List<Irwieisdfsdf> _dfjsfjsjdfwe;
    private int _fdjsdjfsjf = 1;

    private int _lfdlgdlwe;

    private void Ueqeqdasdasd()
    {
        _fdjsdjfsjf = PlayerPrefs.GetInt("CurrentLevel");
        if (_fdjsdjfsjf <= 0)
        {
            _fdjsdjfsjf = 1;
        }
        
        for (int ggdfgd = 0; ggdfgd < _fdjsdjfsjf; ggdfgd++)
        {
            _dfjsfjsjdfwe[ggdfgd].Wrfwersdfsdfsdfs();
            _dfjsfjsjdfwe[ggdfgd].Oroweorsdfsdf += Tewrkrwkerksdf;
        }

        foreach (var fsdfwerw in _dfjsfjsjdfwe)
        {
            fsdfwerw.Oroweorsdfsdf += Tewrkrwkerksdf;
        }
    }

    private void OnDestroy()
    {
        foreach (var ghfhrtyerty in _dfjsfjsjdfwe)
        {
            ghfhrtyerty.Oroweorsdfsdf -= Tewrkrwkerksdf;
        }
    }

    public void Ukfsdkfskdfdfd()
    {
        if (_fdjsdjfsjf == _lfdlgdlwe)
        {
            _dfjsfjsjdfwe[_fdjsdjfsjf].Wrfwersdfsdfsdfs();
            _fdjsdjfsjf++;
        }
        PlayerPrefs.SetInt($"CurrentLevel", _fdjsdjfsjf);
    }

    public void Njgfsdjgjdfjgd()
    {
        PlayerPrefs.SetInt($"CurrentLevel", 0);
    }

    private void Tewrkrwkerksdf(int fdsgdgerte)
    {
        _lfdlgdlwe = fdsgdgerte;
    }
}
