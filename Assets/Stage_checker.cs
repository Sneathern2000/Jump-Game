using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage_checker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Stage_level>().Level = 1;
            Destroy(this.gameObject);
        }
    }
}
