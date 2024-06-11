using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuego : MonoBehaviour
{
    public float minScale;
    public float maxScale;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float newScale = Random.Range(minScale, maxScale);
        transform.localScale = new Vector3(newScale, newScale, newScale);
    }
}
