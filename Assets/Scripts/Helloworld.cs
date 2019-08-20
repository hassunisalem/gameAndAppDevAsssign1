using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helloworld : MonoBehaviour
{
   
    public GameObject redCube;

    void Start()
    {
        
        print("Hello World");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            print("Respect");
        }

   
    }

    public void YoWorld()
    {
        print("Yo World");
    }

    public void SpawnRedCube()

    {
        for (int i = 0; i < 300; i++)
        {
            Instantiate(redCube);
        }
       
   }


}
