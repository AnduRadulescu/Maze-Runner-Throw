using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Text countText;
    public float scoreValue = -5;

    public GameObject item;
    public GameObject tempParent;
    public Transform guide;



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
        if (other.gameObject.CompareTag("Monster"))
        {
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("TorchEffect"))
        {
            item.GetComponent<Rigidbody>().useGravity = false;
            item.GetComponent<Rigidbody>().isKinematic = true;
            item.transform.position = guide.transform.position;
            item.transform.rotation = guide.transform.rotation;
            item.transform.parent = tempParent.transform;
        }
    }
}
