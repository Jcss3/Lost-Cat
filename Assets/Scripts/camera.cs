using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    // transform = faz a camera enxergar o gato
    public Transform Cat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Cat.position.x, transform.position.y, transform.position.z);
    }
}
