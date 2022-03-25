using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement: MonoBehaviour
{
    // Start is called before the first frame update
    //Create endless runner game  you need to spawn enimies at random position and at random interval and spawn the platform endless.
    //if the score is greater than 100 than the speed of the player should increase.

    public int playerSpeed;
    Vector3 direction;
    int score;
    public GameObject temp;
    // TileSpawnManager spawnManager;
    bool isGameOver=false;
    ScoreManagerScript scoreManager;
    GameOverScript gameOverScript;
    public GameObject player;
    public Camera cam;
    void Start()
    {
       //spawnManager =GameObject.Find("TileSpawnManager").GetComponent<TileSpawnManager>();
       scoreManager=GameObject.Find("ScoreManager").GetComponent<ScoreManagerScript>();
        gameOverScript=GameObject.Find("GameOver").GetComponent<GameOverScript>();
        gameOverScript.gameOverPannel.SetActive(false);
      /*  for (int i = 0; i < 10; i++)
        {
            TileSpawnManager.Instance.SpawnTile();
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
        if(player!=null)
        {
            cam.transform.position = new Vector3(player.transform.position.x, cam.transform.position.y, cam.transform.position.z);
        }
        
        if(Input.GetMouseButtonDown(0))
        {
          
            if(direction==Vector3.forward)
            {
                direction = Vector3.left;
            }
            else
            {
                direction = Vector3.forward;
            }
        }
        transform.Translate(direction*playerSpeed*Time.deltaTime);
        if(transform.position.y<-1f&& isGameOver==false)
        {
            isGameOver=true;
            gameObject.SetActive(false);
            gameOverScript.gameOver();
            
        }
        

    }
    private void OnTriggerExit(Collider other)
    {
        // spawnManager.SpawnTile();
      //  if (other.tag=="Player")
          /* other.gameObject.SetActive(false);
            TileSpawnManager.Instance.SpawnTile();*/
         


        
    }
    public void OnTriggerEnter(Collider other)
    {
      if (other.gameObject.tag == "coin")
         {
             scoreManager.Score(10);
             other.gameObject.SetActive(false);
         }
        /* if(other.gameObject.tag=="Right")
         {
             temp = other.gameObject;
             temp.GetComponent<Rigidbody>().isKinematic = false;
             StartCoroutine("MakingObjInactive");
         }
         else if (other.gameObject.tag == "Forward")
         {
             temp = other.gameObject;
             temp.GetComponent<Rigidbody>().isKinematic = false;
             StartCoroutine("MakingObjInactive");

     }*/
    }
    /*private void OnCollisionEnter(Collision collision)
     {
         if (collision.gameObject.tag == "coin")
         {
             scoreManager.Score(10);
             collision.gameObject.SetActive(false);
         }
        /* else if (collision.gameObject.tag == "Right")
         {
             temp=collision.gameObject;
             StartCoroutine("MakingObjInactive");
         }
         else if (collision.gameObject.tag == "Forward")
         {
             temp = collision.gameObject;
             StartCoroutine("MakingObjInactive");
         }

     }*/
    /*IEnumerator MakingObjInactive()
    {
        yield return new WaitForSeconds(1);
        TileSpawnManager.Instance.BackToRightPool(temp);
        TileSpawnManager.Instance.ForwardToRightPool(temp);
    }*/
   

}
 
