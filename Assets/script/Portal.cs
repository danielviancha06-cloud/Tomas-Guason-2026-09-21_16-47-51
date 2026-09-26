using UnityEngine;

public class Portal : MonoBehaviour
{
  

    public string requiredTag;

    [HideInInspector]
    public bool playerInside = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(requiredTag))
        {
            playerInside = true;
            PortalManager.Instance.CheckPortals();
        }
    }
        private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(requiredTag))
        {
            playerInside = false;
        }
    }
}

