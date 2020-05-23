using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundloop : MonoBehaviour
{

    public float speed = 0.2f;
    public GameObject duckEnemy, flyDuckEnemy, tortoiseEnemy, shitAnimalEnemy;

    // Start is called before the first frame update
    void Start()
    {
      duckEnemy = GameObject.Find ("duck");
      flyDuckEnemy = GameObject.Find ("flyduck");
      tortoiseEnemy = GameObject.Find ("tortoise");
      shitAnimalEnemy = GameObject.Find ("shitanimal");
        for (int i = 0; i < 10; i++)
        {
            Instantiate(duckEnemy, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
        }
    //   Instantiate(duckEnemy);
    //   Instantiate(duckEnemy);
    //   Instantiate(duckEnemy);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(Time.time * speed,0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
