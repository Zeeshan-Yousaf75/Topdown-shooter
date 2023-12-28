using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float xPos = 10;
    public float zPos = 20;
    public GameObject[] animalPrefabs;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal",2.0f,1.5f);
    }

    // Update is called once per frame
    void Update()
    {    
       
    }

    void SpawnAnimal()
    {
        int randomAnimal = Random.Range(0, animalPrefabs.Length);

        Vector3 spawnPos = new Vector3(Random.Range(-xPos, xPos), 0, zPos);

        Instantiate(animalPrefabs[randomAnimal], spawnPos, animalPrefabs[randomAnimal].transform.rotation);
    }

}
