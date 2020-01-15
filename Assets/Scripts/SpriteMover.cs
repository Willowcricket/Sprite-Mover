using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMover : MonoBehaviour
{
    public Transform tf;
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        tf = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        { //Holding Shift
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                tf.position = tf.position + Vector3.up * Time.deltaTime * speed;
            }
        }
        else
        { //Not holding Shift
            if (Input.GetKey(KeyCode.UpArrow))
            {
                tf.position = tf.position + Vector3.up * Time.deltaTime * speed;
            }
        }
    }
}