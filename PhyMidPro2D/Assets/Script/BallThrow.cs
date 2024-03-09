using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrow : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] Rigidbody2D Prefab;
    [SerializeField] private float speed;
    [SerializeField] private float degrees = 20;
    [SerializeField] private float rotateSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.eulerAngles = Vector3.forward * degrees;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.eulerAngles = Vector3.back * degrees;
        }

        //float HorizontalRotation = Input.GetAxis("Horizontal");

        // transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, HorizontalRotation * rotateSpeed));
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody2D bullet = Instantiate(Prefab, transform.position, transform.rotation);
            bullet.velocity = transform.right * speed;
        }
    }
    
}
