using UnityEngine;
using UnityEngine.SceneManagement;

public class playerDie : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered by: " + other.gameObject.name);
        if (other.CompareTag("bad"))
        {
            SceneManager.LoadScene(3);
        }
    }
}
