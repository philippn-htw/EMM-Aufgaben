using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    private float angle = 0.0f;

    [SerializeField]
    private float rotationSpeed = 1.0f;

    [SerializeField]
    private float moveSpeed = 1.0f;

    public float externHorizontal;
    public float externVertical;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical");
        angle += Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed;

        Vector3 targetDirection = new Vector3(Mathf.Sin(angle),0,Mathf.Cos(angle));

        transform.rotation = Quaternion.LookRotation(targetDirection);

        transform.position += targetDirection * moveVertical * Time.deltaTime * moveSpeed;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Collectable"))
        {
            //other.gameObject.SetActive(false);
            Destroy(other.gameObject);
        }
    }
}
