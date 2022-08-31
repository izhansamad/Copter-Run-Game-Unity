using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    Rigidbody rb;
    [SerializeField] private int speed = 28000;
    public GameObject gameOverScreen;
    public Text scoreText;
    public Text highScoreText;
    public Text ringCountText;
    public Text TotalringsText;
    int score = 0;
    int ringCount;
    static AudioSource audioSource;
    public AudioClip ringSound;
    public AudioClip heliDes;


    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        //GameOverScreen = GameObject.FindGameObjectWithTag("GameOverScreen");
        rb = GetComponent<Rigidbody>();



    }

    private void Start()
    {
        PlayerPrefs.GetInt("totalRings");
        highScoreText.text = PlayerPrefs.GetInt("highScore") + "m";
        InvokeRepeating("scoreAdd",1 * Time.deltaTime, 0.05f * Time.deltaTime);
    }

   void scoreAdd()
    {
        score++;
        scoreText.text = score + "m";
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            AudioSource.PlayClipAtPoint(heliDes, Camera.main.transform.position);
            gameOverScreen.SetActive(true);
            if (PlayerPrefs.GetInt("highScore")<=score)
            {
                PlayerPrefs.SetInt("highScore", score);
                highScoreText.text = PlayerPrefs.GetInt("highScore").ToString();
            }
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ring"))
        {
            audioSource.PlayOneShot(ringSound);
            //Debug.Log("In RIng Tag = "+ collision.gameObject.tag);
            ringCount++;
            ringCountText.text = ringCount.ToString();
            PlayerPrefs.SetInt("totalRings", PlayerPrefs.GetInt("totalRings") + ringCount);
            Destroy(other.gameObject);
            //score++;
            //scoreText.text = score.ToString();
        }
    }




    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector3(0, speed *Time.deltaTime, 0);
            gameObject.transform.eulerAngles = new Vector3(5,-86,0);

        }
        else if (Input.GetMouseButtonUp(0))
        {
            rb.velocity = new Vector3(0, -speed * Time.deltaTime, 0);
            gameObject.transform.eulerAngles = new Vector3(-5, -86, 0);
        }
        

    }
}
