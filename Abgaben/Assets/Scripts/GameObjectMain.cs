using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectMain : MonoBehaviour
{

    public Transform myPrefab;

    [SerializeField]
    private int objectCount = 10;

    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<objectCount;i++) {
            Random.InitState(i);
            float x = Random.Range(-50.0f, 50.0f);
            float z = Random.Range(-50.0f, 50.0f);
            Vector3 pos = new Vector3(x,0,z);
            Instantiate(myPrefab,pos,Quaternion.Euler(0,0,0));
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
