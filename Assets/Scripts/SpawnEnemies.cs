using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    // Start is called before the first frame update
    CharGen generator;
    void Start()
    {
        generator = this.GetComponent<CharGen>();
        Vector3 pos = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, Camera.main.transform.position.z);
        GameObject enemy1 = generator.GenerateMushroomChar();
        enemy1.transform.position = pos;
       // pos = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z + 0.5f);
        //GameObject enemy2 = generator.GenerateMushroomChar();
        //enemy2.transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
