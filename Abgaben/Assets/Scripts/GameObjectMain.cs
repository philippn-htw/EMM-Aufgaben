using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectMain : MonoBehaviour
{

    public Transform myPrefab;

    public Transform enemy;

    public Transform arParent;

    [SerializeField]
    private int objectCount = 10;

    [SerializeField]
    private int enemyCount = 10;


    // Start is called before the first frame update
    void Start()
    {

        for(int i=0;i<objectCount;i++) {
            Random.InitState(i);
            float x = Random.Range(-50.0f, 50.0f);
            float z = Random.Range(-50.0f, 50.0f);
            Vector3 pos = new Vector3(x,0,z);
            Instantiate(myPrefab,pos,Quaternion.Euler(0,Random.Range(0.0f,360.0f),0),arParent);
        }

        for(int i=0;i<enemyCount;i++) {
            Random.InitState(i+23);
            float x = Random.Range(-50.0f, 50.0f);
            float z = Random.Range(-50.0f, 50.0f);
            Vector3 pos = new Vector3(x,0,z);
            Instantiate(enemy,pos,Quaternion.Euler(0,Random.Range(0.0f,360.0f),0),arParent);
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
