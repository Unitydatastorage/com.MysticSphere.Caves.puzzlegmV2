using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Jtetewrwer : MonoBehaviour
{

    [FormerlySerializedAs("_offMusic")] [SerializeField] private Sprite _sdsadasdasd;
    [FormerlySerializedAs("_onMusic")] [SerializeField] private Sprite _dsadsfsfs;

    [FormerlySerializedAs("_offSounds")] [SerializeField] private Sprite _wertwerwe;
    [FormerlySerializedAs("_onSounds")] [SerializeField] private Sprite _kkgfdgdjfgdj;

    [FormerlySerializedAs("_musicStateImage")] [SerializeField] private Image _vbxcbvbdf;
    [FormerlySerializedAs("_musicStateImage2")] [SerializeField] private Image _rwerwerwr;

    [FormerlySerializedAs("_musicSource")] [SerializeField] private AudioSource _fkgdkfgkd;

    [FormerlySerializedAs("_soundStateImage")] [SerializeField] private Image _vncbncnbc;
    [FormerlySerializedAs("_soundStateImage2")] [SerializeField] private Image _oiigifgidf;

    [FormerlySerializedAs("_soundSource")] [SerializeField] private AudioSource _fhshfsd;

    private bool _yerywyr = true;

    private bool _jhjfjghfjgh = true;



    public void Mbdgkdkgdkfgd()
    {
        _jhjfjghfjgh = !_jhjfjghfjgh;
        _vncbncnbc.sprite = _jhjfjghfjgh ? _kkgfdgdjfgdj : _wertwerwe;
        _oiigifgidf.sprite = _jhjfjghfjgh ? _kkgfdgdjfgdj : _wertwerwe;
        Fewrfsdfwrewe(_vncbncnbc.rectTransform, _jhjfjghfjgh);
        Fewrfsdfwrewe(_oiigifgidf.rectTransform, _jhjfjghfjgh);

        _fhshfsd.mute = !_jhjfjghfjgh;
    }

    public void Nkfkkdkgfdkgf()
    {
        _yerywyr = !_yerywyr;
        _vbxcbvbdf.sprite = _yerywyr ? _dsadsfsfs : _sdsadasdasd;
        _rwerwerwr.sprite = _yerywyr ? _dsadsfsfs : _sdsadasdasd;
        Fewrfsdfwrewe(_vbxcbvbdf.rectTransform, _yerywyr);
        Fewrfsdfwrewe(_rwerwerwr.rectTransform, _yerywyr);

        if (_fkgdkfgkd.isPlaying)
        {
            _fkgdkfgkd.Pause();
        }
        else
        {
            _fkgdkfgkd.Play();
        }
    }

    private void Fewrfsdfwrewe(RectTransform dfhsdhrfwher, bool utyurtuy)
    {
        if (utyurtuy)
        {
            dfhsdhrfwher.anchorMin = new Vector2(0, 0.5f);
            dfhsdhrfwher.anchorMax = new Vector2(0, 0.5f);
            dfhsdhrfwher.pivot = new Vector2(0, 0.5f);
        }
        else
        {
            dfhsdhrfwher.anchorMin = new Vector2(1, 0.5f);
            dfhsdhrfwher.anchorMax = new Vector2(1, 0.5f);
            dfhsdhrfwher.pivot = new Vector2(1, 0.5f);
            
        }
        dfhsdhrfwher.anchoredPosition = Vector2.zero;
    }
    
    public void Kjhfgjhfje(AudioClip dfsdfwer)
    {
        _fhshfsd.clip = dfsdfwer;
        _fhshfsd.Play();
    }
}
