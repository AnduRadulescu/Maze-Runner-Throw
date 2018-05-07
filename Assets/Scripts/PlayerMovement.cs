using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Text countText;
    public GameObject ball;
    public GameObject playerCamera;
    public float ballDistance;
    public float ballThrowingForce;

    private bool holdingball = true;
    private float count;
    Animator anim;
    AudioSource playerAudio;
    private Rigidbody playerRigidbody;
    Vector3 movement;
    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        //turn off cursor
        Cursor.lockState = CursorLockMode.Locked;
        count = 0;
        SetCountText();
        ball.GetComponent<Rigidbody>().useGravity = false;
    }
    void FixedUpdate()
    {
        Vector3 movement;
        float v = Input.GetAxis("Vertical") * speed;
        float h = Input.GetAxis("Horizontal") * speed;
        //Move(h, v);
        v *= Time.deltaTime;
        h *= Time.deltaTime;

        transform.Translate(h, 0f, v);
        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }
        // Throwing the ball
        if (holdingball)
        {
            ball.transform.position = playerCamera.transform.position + playerCamera.transform.forward * ballDistance;
            if (Input.GetMouseButtonDown(0))
            {
                
                holdingball = false;
               ball.GetComponent<Rigidbody>().useGravity = true;
                ball.GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward * ballThrowingForce);
            }
        }
    }
    void Move(float h, float v)
    {
        movement.Set(h, 0f, v);
        movement = movement.normalized * speed * Time.deltaTime;
        playerRigidbody.MovePosition(transform.position + movement);
    }

    // void Animating(float h, float v)
    //{
    //statement which see if the player is moveing 
    //   bool walking = h != 0f || v != 0f;
    // anim.SetBool("IsWalking", walking);
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
          count = count - 5;
          SetCountText();
          //playerAudio.Play();
        }
    }
    //Set the count text
    void SetCountText()
    {
        countText.text = "Score: " + count.ToString();
    }
}
