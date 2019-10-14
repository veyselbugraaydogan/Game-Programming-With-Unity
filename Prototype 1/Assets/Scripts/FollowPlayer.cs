using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{	

    public GameObject vehicle;
    private Vector3 camera_pos =new Vector3(0,5,-7);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = vehicle.transform.position + camera_pos;
    }
}
