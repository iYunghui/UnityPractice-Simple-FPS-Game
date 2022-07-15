using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;
    private int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(counter >= Random.Range(200, 1000)) {
            Instantiate(enemy, new Vector3(Random.Range(-4.0f, 4.0f), 0.5f, 4), Quaternion.identity);
            counter = 0;
        }
        counter += 1;
    }
}
