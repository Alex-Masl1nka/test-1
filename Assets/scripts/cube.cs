using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    public int a = 1;
    public int b = 2;
    // Start is called before the first frame update
    void Start()
    {
        // сложение
        //a = a + 1;
        //a += 1;
        //a++;
        print("сумма a и b " + (a+b));


        // вычитание
        //b = b - 1;
        //b -= 1;
        //b--;
        print("разность a и b " + (a - b));

        // умножение
        //a = a * 1;
        //a *= 1;
        print("произведение a и b " + (a * b));

        // деление
        //a = a / 1;
        //a /= 1;
        print("деление a и b " + (float)a / b);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
