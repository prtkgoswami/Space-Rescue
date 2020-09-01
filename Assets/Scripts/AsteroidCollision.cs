using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AsteroidCollision : MonoBehaviour
{
    [SerializeField] GameObject playerShip;
    [SerializeField] GameObject poofParticle;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.GetComponent<PlayerShip>())
        {
            Debug.Log("Player Ship Collided");
            Instantiate(poofParticle, playerShip.transform.position, Quaternion.identity);
            Destroy(playerShip);

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void TakeDamage()
    {
        transform.localScale -= new Vector3(0.3f, 0.4f, 0);

        if (transform.localScale.y < 0.1f)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
