using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{
    public float speed;
    Rigidbody rg;

    public GameObject playerExplosion;

    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(x,0.0f,z);

        rg.AddForce(movement*speed);
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            Instantiate(playerExplosion, transform.position, Quaternion.identity);
            SceneManager.LoadScene(0);
        }
    }
}
