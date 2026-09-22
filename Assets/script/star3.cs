using UnityEngine;
using UnityEngine.SceneManagement;

public class star3 : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(3);
        }

        else if (collision.gameObject.tag == "player2")

        {
            SceneManager.LoadScene(3);
        }
    }

}





