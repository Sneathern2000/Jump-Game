using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection_wave : MonoBehaviour
{
    [SerializeField] private tutorial_Controller tutorial;
    [SerializeField, Range(1, 20)] int movelevel = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player") tutorial.move = movelevel;
    }

}
