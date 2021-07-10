using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracking_camera : MonoBehaviour
{
    [SerializeField] private GameObject child;
    [SerializeField] private GameObject Player;
    [SerializeField] private float disply;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var distance = Vector3.Distance(transform.position, Player.transform.position);
        if (distance <= disply)
        {
            child.transform.LookAt(Player.transform);
        }
    }
}
