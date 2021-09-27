using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGroundScript : MonoBehaviour
{
    Vector3 originalPos;
    // Start is called before the first frame update
    void Start()
    {
        originalPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if((-1 *transform.position.x) >= 60){
            transform.position = originalPos;
        }
        transform.position += Vector3.left * GameManager.gameSpeed * Time.deltaTime;
    }
}
