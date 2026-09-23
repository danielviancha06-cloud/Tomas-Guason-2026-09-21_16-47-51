using UnityEngine;
using UnityEngine.SceneManagement;

public class star : MonoBehaviour

{
    public string requiredTag;
    public string nextScene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(requiredTag))
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}


