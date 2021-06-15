using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    [SerializeField] private InputField _firstVariable;
    [SerializeField] private InputField _twoVariable;
    [SerializeField] private InputField _valueSum;



    /// <summary>
    /// Метод для складывания двух чисел и вывод его
    /// </summary>
    public void Plus()
    {
        float a = float.Parse(_firstVariable.text);
        float b = float.Parse(_twoVariable.text);

        float sum = a + b;
        _valueSum.text = sum.ToString();
    }

    /// <summary>
    /// Метод для вычитания двух чисел и вывод его
    /// </summary>
    public void Minus()
    {
        float a = float.Parse(_firstVariable.text);
        float b = float.Parse(_twoVariable.text);

        float sum = a - b;
        _valueSum.text = sum.ToString();
    }

    /// <summary>
    /// Метод для умножения двух чисел и вывод его
    /// </summary>
    public void Multiplications()
    {
        float a = float.Parse(_firstVariable.text);
        float b = float.Parse(_twoVariable.text);

        float sum = a * b;
        _valueSum.text = sum.ToString();
    }

    /// <summary>
    /// Метод для деления двух чисел и вывод его
    /// </summary>
    public void Division()
    {
        float a = float.Parse(_firstVariable.text);
        float b = float.Parse(_twoVariable.text);

        float sum = a / b;
        _valueSum.text = sum.ToString();
    }


    

}
