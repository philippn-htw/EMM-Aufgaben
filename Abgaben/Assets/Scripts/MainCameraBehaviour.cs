using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraBehaviour : MonoBehaviour
{

    public Transform target;

    private Vector3 offsetVector = new Vector3(0,2,-5);

    private Quaternion currentRotation;

    // Start is called before the first frame update
    void Start()
    {
        currentRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 offsetRotated = target.transform.rotation * offsetVector;

        transform.position = target.transform.position + offsetRotated;
        transform.rotation = target.transform.rotation;
    }
}
