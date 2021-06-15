using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Comparisons : MonoBehaviour
{
    [SerializeField] private InputField _firstVariable;
    [SerializeField] private InputField _twoVariable;
    [SerializeField] private InputField _maxNumber;

    /// <summary>
    /// Сравниваем два числа и выявляем масимальное
    /// </summary>
    public void TwoNumberComparisons()
    {
        float a = float.Parse(_firstVariable.text);
        float b = float.Parse(_twoVariable.text);

        if (a > b)
        {
            _maxNumber.text = a.ToString();
        }
        else if (a == b)
        {
            _maxNumber.text = a.ToString();
        }
        else
        {
            _maxNumber.text = b.ToString();
        }
    }
}
