using UnityEngine;
using UnityEngine.SceneManagement;

public class CarResp : MonoBehaviour
{
  

    void OnTriggerEnter2D(Collider2D CarHit)
    {
        if (CarHit.CompareTag("Hit"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
