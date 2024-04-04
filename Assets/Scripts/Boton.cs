using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton : MonoBehaviour
{
    public GameObject botonNormalGO;
    public GameObject botonPresionadoGO;
    public CoheteScript coheteScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnMouseUp()
    {
        botonNormalGO.SetActive(true);
        botonPresionadoGO.SetActive(false);
        coheteScript.speed = 0;
    }
    private void OnMouseDown()
    {
        botonNormalGO.SetActive(false);
        botonPresionadoGO.SetActive(true);
        coheteScript.speed = 0.5f;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
