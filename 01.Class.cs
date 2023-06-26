using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        /*
            // 1 Tane Araba Tanimlama
        Araba araba1 = new Araba();
        
        print(araba.marka);     // Markasina erisebiliriz cunku bu ozellik "public" olarak belirlenmis.
        print(araba.model);     // ''
        print(araba.fiyat);     // Fiyatina erisemeyiz cunku bu ozellik "private" olarak belirlenmis.

        araba1.arabaSurmek();
        */

            // 1'den Fazla Araba Tanimlama
        Araba araba1 = new Araba();
        araba1.marka = "BMW";
        araba1.model = "X5";
        araba1.fiyat = 500000;

        print("1. Arabanin Ozellikleri:");
        print(araba1.marka);
        print(araba1.model);
        print(araba1.fiyat);

        Araba araba2 = new Araba();
        araba2.marka = "Audi";
        araba2.model = "Q8";
        araba2.fiyat = 2000000;

        print("2. Arabanin Ozellikleri:");
        print(araba2.marka);
        print(araba2.model);
        print(araba2.fiyat);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
