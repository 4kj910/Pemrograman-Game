using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FornWhileLoop();
        Array();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //no.1
      void FornWhileLoop()
    {
       
        int HP = 100;
        int armor = 80;
        while (HP  > 0)
        {
            HP -= 10;
            Debug. Log("sisa hp: " + HP);

            if (HP > 50)
            {
                Debug.Log("Pemain aman");
            }

            else if (HP >20)
            {
                Debug.Log("Pemain harus hati-hati");
            }

            if (armor > 30 && HP > 50)
            {
                Debug.Log("pemain siap tempur");
            }

            else
            {
                Debug.Log("Pemain perlu bersiap");
            }

        }

        //no.3


            Debug.Log("mati :(");
    }

    //no.2
    void Array()
    {
        int[] scores = { 100, 90, 85, 70, 60 };
        int total = 0;
        foreach (int i in scores)
        {
            total += i;
        }
        int rerata = total / scores.Length;
        Debug.Log("rerata score: " + rerata);

        if (total > 80)
        {
            Debug.Log("Pemain berkualitas tinggi");
        }
        else
        {
            Debug.Log("Pemain butuh latihan");
        }
    }

}
