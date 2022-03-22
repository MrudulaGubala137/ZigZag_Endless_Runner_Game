using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
   public GameObject rightTile;
   public GameObject currentTile;
    public GameObject forwardTile;
    public GameObject[] tilesPrefab;
    int count = 10;
    float time;
    //SingleTon means we can only create single object out of it. We can't create multiple objects from it.
    private static TileSpawnManager instance;

    // static TileSpawnManager Instance { get => instance; }
  /*  private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
       
    }*/
  public static TileSpawnManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<TileSpawnManager>();
            }
            return instance;
        }
    }
    void Start()
    {
        
        for (int i = 0; i < count; i++)
        {
            SpawnTile();

        }
    }

    public void SpawnTile()
    {
        int index = Random.Range(0, 10);
        if(index==5)
        {
            currentTile.transform.GetChild(3).gameObject.SetActive(true);
        }
        int k = Random.Range(0, 2);
        //Instantiate(rightTile,currentTile.transform.GetChild(1).position,Quaternion.identity);
        currentTile = Instantiate(tilesPrefab[k], currentTile.transform.GetChild(k).position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        time=time+Time.deltaTime;
        if(time>2f)
        {
            Destroy(GameObject.FindGameObjectWithTag("Tile"));
            time = 0f;
        }
    }

   
}
