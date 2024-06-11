using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject asteridePrefab;
    public GameObject asteroidePrefab2;
    public Vector3 newPosition;
    public float minX;
    public float maxX;
    public float interval;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(CloneAsteroide), 0, interval);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CloneAsteroide();
        }
    }
    public void CloneAsteroide()
    {
        float randomx = Random.Range(minX, maxX);
        newPosition = new Vector3(randomx, 9);
        
        int randomPrefab = Random.Range(0, 2);
        if(randomPrefab == 0)
        {
            Instantiate(asteridePrefab, newPosition, Quaternion.identity);
        }
        else
        {
            Instantiate(asteroidePrefab2, newPosition, Quaternion.identity);
        }
    }
}
