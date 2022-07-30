using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCube : MonoBehaviour
{
    private Transform mainCube;
    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject collisionEffect;

    public bool startGame = false;

    // Start is called before the first frame update
    void Start()
    {
        mainCube = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D)) {
            mainCube.Translate(2*Time.deltaTime, 0, 0);
        }
        else if(Input.GetKey(KeyCode.A)) {
            mainCube.Translate(-2*Time.deltaTime, 0, 0);
        }

        if(Input.GetKeyDown(KeyCode.Space)) {
            // bullet
            Instantiate(bullet, mainCube.position, Quaternion.identity);
        }
    }

    private void OnTriggerEnter(Collider collider) {
        if(collider.gameObject.tag == "Enemy") {
            Debug.Log("QQ");
            Instantiate(collisionEffect, collider.transform.position, Quaternion.identity);
        }
    }
}
