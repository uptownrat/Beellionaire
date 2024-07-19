using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeClass : MonoBehaviour
{
    // bee created in random x y pos
    // selects 1 of 4 directions to go in diagonally
    // bumps around like a screensaver

    //[SerializeField] GameObject bee;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
