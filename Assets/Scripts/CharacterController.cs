using UnityEngine;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour
{
    public Transform rayStart; // object collide

    [SerializeField] private GameObject fadeScreen;

    private Rigidbody rb; 
    private Animator anim;
    private bool walkingRight = true;
    private bool isFalling = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    private void Start()
    {
        FindObjectOfType<Road>().StartBuildingRoad();
    }

    private void FixedUpdate()
    {
        rb.transform.position = transform.position + transform.forward * 2 * Time.deltaTime * Score.speedIncrease;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isFalling)
        {
            Switch();
        }
        RaycastHit hit;
        if(!Physics.Raycast(rayStart.position, -transform.up, out hit, Mathf.Infinity) && transform.position.y < 0.3f) // if there is no collide on the bottom 
        {
            anim.SetTrigger("isFalling");
            isFalling = true;
            fadeScreen.GetComponent<Animation>().Play();
            Invoke("GameOver", 2.9f);
        }
    }

    private void Switch()
    {
        walkingRight = !walkingRight;
        if (walkingRight)
        {
            transform.rotation = Quaternion.Euler(0, 45, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, -45, 0);
        }
    }

    private void GameOver()
    {
        LoadScene.GameOver();
    }
}
