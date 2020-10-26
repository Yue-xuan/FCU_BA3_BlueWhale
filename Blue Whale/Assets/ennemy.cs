using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using Random = UnityEngine.Random;

public class enemmyscrip : MonoBehaviour


{
    private int enemmyDistance = 0;
    private int enemmyCount = 10;

    private string[] enemies = new string[6];



    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            // enemmySearch();
            // enemmyDestruction();
            enemmyroster();
        }
    }

    void enemmySearch()
    {
        enemmyDistance = Random.Range(1, 10);

        if (enemmyDistance >= 8)
        {
            print("enemmy at far away");
        }

        if (enemmyDistance >= 4 && enemmyDistance < 8)
        {
            print("enemmy at medium range");
        }

        if (enemmyDistance < 4)
        {
            print("they are getting close!");
        }

    }

    void enemmyDestruction()
    {
        while (enemmyCount > 0)
        {
            print("There is an enemy!" + enemmyCount);
            enemmyCount--;
            // enemmyCount=enemmyCount-1;
        }
    }
    void enemmyroster()
    {
        enemies[0] = "Orc";
        enemies[1] = "Dragon";
        enemies[2] = "Squid";
        enemies[3] = "Devil Whale";
        enemies[4] = "Tricerotop";
        enemies[5] = "Lucifa";

        foreach (string enemy in enemies)
        {
            print(enemy);
        }



    }

}