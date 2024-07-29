using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "ContentBlock", menuName = "ScriptableObject", order = 1)]
public class Jfsjfjgwejtfgdfg : ScriptableObject
{
    [FormerlySerializedAs("_items")] [HideInInspector] [SerializeField] private List<QuizModel> _ruwurwurwsdf;
    [FormerlySerializedAs("currentQuiz")] [SerializeField] private QuizModel riweirwirisdf;

    private int rjwejrjsdfjsdf;

    public List<QuizModel> Ruwurwurwsdf => _ruwurwurwsdf;

    private Dictionary<string, List<QuizModel>> _tyriyiryirt;

    private void OnEnable()
    {
        _tyriyiryirt = new Dictionary<string, List<QuizModel>>();
    }

    #region SoInit
    public void CreateItem()
    {
        if (_ruwurwurwsdf == null)
        {
            _ruwurwurwsdf = new List<QuizModel>();
        }

        var item = new QuizModel();
        
        _ruwurwurwsdf.Add(item);
        //item.ID = _items.Count;
        riweirwirisdf = item;
        rjwejrjsdfjsdf = _ruwurwurwsdf.Count - 1;
    }

    public void RemoveItem()
    {
        _ruwurwurwsdf.Remove(riweirwirisdf);
        if (_ruwurwurwsdf.Count > 0)
            riweirwirisdf = _ruwurwurwsdf[0];
        else CreateItem();
        rjwejrjsdfjsdf = 0;
    }

    public void NextItem()
    {
        if (rjwejrjsdfjsdf + 1 < _ruwurwurwsdf.Count)
        {
            rjwejrjsdfjsdf++;
            riweirwirisdf = _ruwurwurwsdf[rjwejrjsdfjsdf];
        }
    }
    public void PrevItem()
    {
        if (rjwejrjsdfjsdf > 0)
        {
            rjwejrjsdfjsdf--;
            riweirwirisdf = _ruwurwurwsdf[rjwejrjsdfjsdf];
        }
    }
    #endregion
}

public enum Yryweyryweyrwr {
    RJWEJRJWERJWJER, KEKWEKQKWE
}

[System.Serializable]
public class QuizModel {
    [FormerlySerializedAs("id")] public int wueruwer;

    public int questionNumber; // Start count from 1
    [TextArea(3, 10)]
    public string questionText;
    public int rightAnswer; // from 0 to n - 1 answers
    [CanBeNull] public Sprite image;
    public List<string> answerText = new List<string>(3); // capacity = answers count
}
