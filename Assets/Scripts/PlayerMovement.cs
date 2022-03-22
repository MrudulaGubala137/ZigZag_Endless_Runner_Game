using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement: MonoBehaviour
{
    // Start is called before the first frame update
    public int playerSpeed;
    Vector3 direction;
    int score;
    // TileSpawnManager spawnManager;
    ScoreManagerScript scoreManager;
    void Start()
    {
       //spawnManager =GameObject.Find("TileSpawnManager").GetComponent<TileSpawnManager>();
       scoreManager=GameObject.Find("ScoreManager").GetComponent<ScoreManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
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

    }
    private void OnTriggerExit(Collider other)
    {
        // spawnManager.SpawnTile();
      //  if (other.tag=="Player")
        
            TileSpawnManager.Instance.SpawnTile();
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag =="coin")
        {
            scoreManager.Score(10); 
            collision.gameObject.SetActive(false);
        }
        

    }
}
