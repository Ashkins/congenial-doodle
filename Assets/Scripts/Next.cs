using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D Nexlvl)
    {
        if (Nexlvl.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
