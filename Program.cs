using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionAlgo
{
    class Koleksion1
    {
        
        static void Main(string[] args)
        {

            Arabalar araba=new Arabalar();
            araba.marka="BMW";
            araba.model="3.20i";
            araba.yıl=2010;
            araba.fiyat=450000f;
            araba.ArabaDetay();


        }

        class Arabalar{

            public string model;
            public string marka;
            public int yıl;
            public float fiyat;

            public void ArabaDetay(){
                Console.WriteLine("Marka:"+marka);
                Console.WriteLine("Model:"+model);
                Console.WriteLine("Yıl:"+yıl);
                Console.WriteLine("Fiyat:"+fiyat+" $");
                Console.WriteLine("Yaşı:"+(DateTime.Now.Year-yıl).ToString());
            }
        }
    }
}