using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float spead = 4;
    public Rigidbody rb;
    float HorizontalInput;
    public float HorizontalMultiPlayer = 2;
    bool alive = true;
    public bool isgrounded = true;
    public static PlayerMovement instance;
   
    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    private void FixedUpdate()
    {
        if (!alive) return;
        if (CountDown.instance.End() == false) {

            Vector3 ForwardMove = transform.forward * spead * Time.fixedDeltaTime;
            Vector3 HorizontalMove = transform.right * HorizontalInput * spead * Time.fixedDeltaTime * HorizontalMultiPlayer;
            rb.MovePosition(rb.position + ForwardMove + HorizontalMove);
        }

    }

    // Update is called once per frame
    private void Update()
    {
        if (CountDown.instance.End() == false)
        {
            HorizontalInput = Input.GetAxis("Horizontal");
            if (isgrounded && Input.GetButtonDown("Jump"))
            {
                Jump();
            }
            if (transform.position.y < -30)
            {
                Die();
            }


        }
    }
    void Jump()
    {

        rb.AddForce(new Vector3(0, 15, 0), ForceMode.Impulse);
        isgrounded = false;

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {

            isgrounded = true;

        }

    }



    public void Die()
    {
        alive = false;
        SceneManager.LoadScene("EndMenu");
        PlayerPrefs.SetString("lastLoadedScene", SceneManager.GetActiveScene().name);
        PlayerPrefs.SetInt("Score", Score.instance.ScoreNum);



    }

    public void Speed ()
        {
        spead = spead + 1 ;
        }


}
