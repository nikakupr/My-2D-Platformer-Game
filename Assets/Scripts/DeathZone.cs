using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Animator playerAnimator = collision.gameObject.GetComponent<Animator>();
            if (playerAnimator != null)
            {
                playerAnimator.SetTrigger("Death");
            }

            Player playerScript = collision.gameObject.GetComponent<Player>();
            if (playerScript != null)
            {
                playerScript.enabled = false; // Disable Player script to prevent movement during death animation
            }

            gameObject.SetActive(false); // Deactivate the DeathZone GameObject

            // Reload the scene after 1 second using Invoke
            Invoke("ReloadScene", 1f);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
