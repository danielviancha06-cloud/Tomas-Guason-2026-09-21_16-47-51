using UnityEngine.SceneManagement;
using UnityEngine;


public class PortalManager : MonoBehaviour
{
    public static PortalManager Instance;

    public Portal[] portals;

    public string nextScene;

    private void Awake()
    {
        Instance = this;
    }

    public void CheckPortals()
    {
        foreach (Portal portal in portals)
        {
            if (!portal.playerInside)
            {
                return;
            }
        }

        SceneManager.LoadScene(nextScene);
    }
}