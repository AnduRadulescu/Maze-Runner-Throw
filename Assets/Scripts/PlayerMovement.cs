using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Text countText;
    public GameObject ball1;
    public GameObject ball2;
    public GameObject ball3;
    public GameObject ball4;
    public GameObject ball5;
    public float scoreValue = -5;
    

    private float count;
    Animator anim;
    AudioSource playerAudio;
    private Rigidbody playerRigidbody;
    Vector3 movement;
    private bool holdingball = true;

    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        //turn off cursor
        Cursor.lockState = CursorLockMode.Locked;
        count = 0;
        ball1.GetComponent<Rigidbody>().useGravity = false;
        ball2.GetComponent<Rigidbody>().useGravity = false;
        ball3.GetComponent<Rigidbody>().useGravity = false;
        ball4.GetComponent<Rigidbody>().useGravity = false;
        ball5.GetComponent<Rigidbody>().useGravity = false;

    }
  
    void FixedUpdate()
    {
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
            Count.score += scoreValue;
            //playerAudio.Play();
        }
    }
  
}
