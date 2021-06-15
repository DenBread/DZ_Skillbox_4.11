using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SquareLevelling : MonoBehaviour
{
    [SerializeField] private InputField _firstVariable;
    [SerializeField] private InputField _twoVariable;
    [SerializeField] private InputField _threeVariable;
    [SerializeField] private InputField _valueSum;

    private double a;
    private double b;
    private double c;
    private double D;
    private double x1;
    private double x2;
     
    public void Raschet()
    {
        a = double.Parse(_firstVariable.text);
        b = double.Parse(_twoVariable.text);
        c = double.Parse(_threeVariable.text);

        D = Math.Pow(b, 2) - 4 * a * c;
        if (D > 0 || D == 0)
        {
            x1 = (-b + Math.Sqrt(D)) / (2 * a);
            x2 = (-b - Math.Sqrt(D)) / (2 * a);
            //Console.WriteLine("x1= {0}\n x2= {1}", x1, x2);
            //Console.ReadKey();

        }


        else
        {
            //Console.WriteLine("Действительных корней нет");
            //Console.ReadKey();
            _twoVariable.text = "Действительных корней нет";
        }

        _valueSum.text = "x1 = " + x1 + " x2 = " + x2;
        print("x1 = " + x1 + " x2 = " + x2);

    }
}
