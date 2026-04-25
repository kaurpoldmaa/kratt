using UnityEngine;

public class PagePickup : MonoBehaviour
{
    public AudioClip pickupSound;
    private bool canPick = false;

    private void Update()
    {
        if (canPick && Input.GetKeyDown(KeyCode.F))
        {
            GameState.CollectPage();

            if (pickupSound)
                AudioSource.PlayClipAtPoint(pickupSound, transform.position);

            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            canPick = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            canPick = false;
    }
}
