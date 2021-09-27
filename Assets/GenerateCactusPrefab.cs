using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCactusPrefab : MonoBehaviour
{
    // Start is called before the first frame update
    private float cactusSpawnTime = 2;
    public float minCactiTime = 1;
    public float maxCactiTime = 1;
    private float timer = 0;
    public GameObject cactusSmallOne; 
    public GameObject cactusBigOne; 
    public GameObject cactusBigMulti; 
    public GameObject bird; 

    void Start()
    {
            GameObject newCactus = Instantiate(cactusSmallOne);
            Destroy(newCactus, 6);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > cactusSpawnTime){
            int type = Random.Range(1, 4);
            
            if(type == 1){
                    GameObject newCactus = Instantiate(cactusSmallOne);
                    Destroy(newCactus, 6);
            }

            else if(type == 2) {

                type = Random.Range(1, 3);
                if(type == 1){
                    GameObject newCactus = Instantiate(cactusBigOne);
                    Destroy(newCactus, 6);
                }
                else{
                    GameObject newCactus = Instantiate(cactusBigMulti);
                    Destroy(newCactus, 6);
                }
            }
            else{
                GameObject newBird = Instantiate(bird);
                Destroy(newBird, 6);
            }


            timer = 0;
            cactusSpawnTime = Random.Range(minCactiTime, maxCactiTime);
        }
        timer += Time.deltaTime;
    }
}
