using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // s = u t  s- distance = u (velocity) * t (time)

        if (Input.GetKey(KeyCode.W))
        {
           transform.position += Vector3.up * Time.deltaTime;
        }

        // s = u t  s- distance = u (velocity) * t (time)

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime;
        }

        // s = u t  s- distance = u (velocity) * t (time)

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime;
        }

        // s = u t  s- distance = u (velocity) * t (time)

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * Time.deltaTime;
        }


    }
}
