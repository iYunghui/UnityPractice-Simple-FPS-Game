using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField] private Rigidbody bulletRigibcody;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // this.transform.Translate(0, 0, 2*Time.deltaTime);
        bulletRigibcody.AddForce(Vector3.forward*10);
        if(transform.position.z > 10) Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Enemy") {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Debug.Log("kill");

            SoundManager.soundManager.playSound(0);
        }
        
    }
}
