using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerControl : MonoBehaviour
{
   public float speed = 5f;
    int health = 10;
    public TMP_Text healthText;
    int score = 0;
    float thisIsADecimal = 3.14f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(thisIsADecimal);
        thisIsADecimal++;
        Debug.Log(thisIsADecimal);

        healthText.text = health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(12, 2, 15);

        Vector3 currentPos = transform.position;


        if (Input.GetKey(KeyCode.D))
        {
            currentPos.x = currentPos.x + speed * Time.deltaTime;
            //newPos.x++;
        }
        if (Input.GetKey(KeyCode.A))
        {
            currentPos.x = currentPos.x - speed * Time.deltaTime;
            //newPos.x--;
        }
        if (Input.GetKey(KeyCode.W))
        {
            currentPos.z = currentPos.z + speed * Time.deltaTime;
            //newPos.z++;
        }
        if (Input.GetKey(KeyCode.S))
        {
            currentPos.z = currentPos.z - speed * Time.deltaTime;
            //newPos.z--;
        }


        transform.position = currentPos;
    }

    void OnCollisionEnter(Collision otherThing)
    {
        Debug.Log(otherThing.gameObject.name);
        if (otherThing.gameObject.name == "Enemy")
        {
            health--;
            healthText.text = health.ToString();
        }
    }

}
