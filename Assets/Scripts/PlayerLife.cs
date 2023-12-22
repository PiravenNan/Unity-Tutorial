using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //import needed to reload

public class PlayerLife : MonoBehaviour
{
    bool dead = false;
    private void Update()
    {
        if (transform.position.y < -2f && !dead)
        {
            Die();
        }
    }

    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.CompareTag("Enemy Body"))
        {
            GetComponent<MeshRenderer>().enabled = false; //Stops rendering player
            GetComponent<Rigidbody>().isKinematic = true; //Disables phyics on player object
            GetComponent<PlayerMovement>().enabled = false; //Cannot run playermovement script
            Die();
        }
    }

    void Die()
    {
        dead = true;
        Invoke(nameof(ReLoadLevel),1.3f);

    }

    void ReLoadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
