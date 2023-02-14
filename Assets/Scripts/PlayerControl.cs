using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    float health = 10f;
    int score = 0;
    float thisIsADecimal = 3.14f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(thisIsADecimal);
        thisIsADecimal++;
        Debug.Log(thisIsADecimal);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(12, 2, 15);

        Vector3 newPos = transform.position;


        if (Input.GetKey(KeyCode.D))
        {
            newPos.x++;
        }
        if (Input.GetKey(KeyCode.A))
        {
            newPos.x--;
        }
        if (Input.GetKey(KeyCode.W))
        {
            newPos.z++;
        }
        if (Input.GetKey(KeyCode.S))
        {
            newPos.z--;
        }


        transform.position = newPos;
    }
}
