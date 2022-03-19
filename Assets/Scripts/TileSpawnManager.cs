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
    void Start()
    {
        
        for (int i = 0; i < count; i++)
        {
          int k = Random.Range(0, 2);
            //Instantiate(rightTile,currentTile.transform.GetChild(1).position,Quaternion.identity);
            currentTile=Instantiate(tilesPrefab[k], currentTile.transform.GetChild(k).position, Quaternion.identity);
            Destroy(currentTile,3f);

        }
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
   
}
