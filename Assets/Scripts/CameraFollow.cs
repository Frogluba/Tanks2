using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Transform target2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // var pos = (target.position + target2.position) / 2;
        var pos = Vector3.Lerp(target.position, target2.position, 0.5f);
        transform.position = Vector3.Lerp(transform.position, pos, 0.01f);
    }
}
