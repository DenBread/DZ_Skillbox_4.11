using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThreeNumbersComparer : MonoBehaviour
{

    [SerializeField] private InputField _firstVariable;
    [SerializeField] private InputField _twoVariable;
    [SerializeField] private InputField _threeVariable;
    [SerializeField] private InputField _maxNumber;

    /// <summary>
    /// Сравниваем два числа и выявляем масимальное
    /// </summary>
    public void NumbersComparisons()
    {
        float a = float.Parse(_firstVariable.text);
        float b = float.Parse(_twoVariable.text);
        float c = float.Parse(_threeVariable.text);

        float d = Math.Max(Math.Max(a, b), c);

        _maxNumber.text = d.ToString();
    }
}
