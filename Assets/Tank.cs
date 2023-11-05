using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public float speed = 5;
    public float rotateSpeed = 90;

    public string verticalAxis;
    public string horizontalAxis;

    public KeyCode shootKey;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var ver = Input.GetAxis(verticalAxis);
        transform.position += transform.forward * speed * Time.deltaTime * ver;

        var hor = Input.GetAxis(horizontalAxis);
        transform.Rotate(0, rotateSpeed * Time.deltaTime * hor, 0);


        if (Input.GetKeyDown(shootKey))
        {
            print("SHOOT");
        }
    }
}
