using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private Animator myAnimator;

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        transform.position += transform.right * horizontal * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            myAnimator.SetTrigger("Jump");
        }

        if (Input.GetMouseButtonDown(0))
        {
            myAnimator.SetTrigger("Attack");
        }
        if (horizontal > 0)
        {
            Vector3 scale = transform.localScale;
            scale.x = 1f;
            transform.localScale = scale;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                myAnimator.SetTrigger("Run");
            }

        }
        else if (horizontal < 0)
        {
            Vector3 scale = transform.localScale;
            scale.x = -1f;
            transform.localScale = scale;

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                myAnimator.SetTrigger("Run");
            }
        }

        if (horizontal != 0)
        {
            myAnimator.SetBool("Walk", true);

        }
        else
        {
            myAnimator.SetBool("Walk", false);
        }
    }
}
