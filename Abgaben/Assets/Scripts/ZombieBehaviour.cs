using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieBehaviour : MonoBehaviour
{

    public Animator zombieAnim;

    [SerializeField]
    private float distance = 10.0f;
    [SerializeField]
    private float enemySpeed = 0.4f;

    private GameObject player;

    private bool isWalking = false;

    // Start is called before the first frame update
    void Start()
    {   
        player = GameObject.Find("/Player");
        zombieAnim = GetComponent<Animator>();
        zombieAnim.Play("Stand");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 playerEnemyVector = player.transform.position - transform.position;
        if(playerEnemyVector.magnitude < distance)
        {
            zombieAnim.Play("Walk");
            Quaternion targetRotation = Quaternion.LookRotation(playerEnemyVector, Vector3.up);
            transform.rotation = targetRotation;
            transform.position += new Vector3(playerEnemyVector.x,0,playerEnemyVector.z) * Time.deltaTime * enemySpeed;
            isWalking = true;
        } else if(playerEnemyVector.magnitude > distance && isWalking) {
            isWalking = false;
            zombieAnim.Play("Stand");
        }
    }
}
