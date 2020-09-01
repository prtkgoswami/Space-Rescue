using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    [SerializeField] float forwardForce = 8f;
    [SerializeField] float sideForce = 2f;
    [SerializeField] float sideIncrement = 2f;
    public GameObject poofParticle;
    [SerializeField] Rigidbody2D rb;

    Vector3 _initialPosition;

    private void Start()
    {
        _initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float verticalMove = Input.GetAxis("Vertical");
        float horizontalMove = Input.GetAxis("Horizontal");
        Vector3 movementVector = new Vector3(horizontalMove * forwardForce, verticalMove * sideForce, 0);
        //Vector3 movementVector = new Vector3(1 * forwardForce, verticalMove * sideForce, 0);
        movementVector *= Time.deltaTime;
        transform.Translate(movementVector);

        if (transform.position.y >=5 ||
            transform.position.y <= -5)
        {
            transform.position = new Vector3(transform.position.x, _initialPosition.y, 0);
        }
    }

    public void TakeDamage()
    {
        Debug.Log("Player Hit");
        Instantiate(poofParticle, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
