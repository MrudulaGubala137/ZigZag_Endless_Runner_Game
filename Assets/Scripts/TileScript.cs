using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    void Start()
    {
        rb = GetComponentInParent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator FallDown()
    {
        yield return new WaitForSeconds(2);
        rb.isKinematic = false;
        yield return new WaitForSeconds(3);
        rb.isKinematic=true;
        //Debug.Log(gameObject.name);
        if (TileSpawnManager.Instance.name == "RightTile")
        {
            TileSpawnManager.Instance.BackToRightPool(gameObject);
        }
        if (TileSpawnManager.Instance.name == "ForwardTile")
        {
            TileSpawnManager.Instance.BackToForwardPool(gameObject);
        }

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            TileSpawnManager.Instance.SpawnTile();
            StartCoroutine(FallDown());
        }
        
    
}
  
    
}
