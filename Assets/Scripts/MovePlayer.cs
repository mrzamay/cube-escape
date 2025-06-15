using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 5f;

    public float HorizontalInput;
    public float VerticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");


        transform.Translate(Vector3.right * Time.deltaTime * speed * HorizontalInput);
        transform.Translate(Vector3.up * Time.deltaTime * speed * VerticalInput);

        void OnColliderEnter2D(Collider2D other)
        {
            Debug.Log("hsflkjsahkjfhdlkjfds");
        }
    }
}
