using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] blocks;
    public GameObject coin;
    private float startDelay = 2;
    private float spawnInterval = 3f;
   
    int blockIndex;
    // Start is called before the first frame update
    void Start()
    {
      
        
        InvokeRepeating("SpawnRandomBlock", startDelay, spawnInterval);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        blockIndex = Random.Range(0, 4);
        blocks[blockIndex].SetActive(true);
      
    }
    void SpawnRandomBlock()
    {
         
        
     
        for (int i = 0; i < blocks.Length ; i++)
        {
          
            if (i == blockIndex)
            {
               
                blocks[blockIndex].SetActive(false);
                Instantiate(coin, blocks[blockIndex].transform.position, blocks[blockIndex].transform.rotation);
            }
            else 
            {
                
                Instantiate(blocks[i], blocks[i].transform.position, blocks[i].transform.rotation);
               
            }
        }
            
       
    }
   
}
