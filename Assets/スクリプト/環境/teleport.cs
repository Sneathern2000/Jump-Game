using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    private GameObject player;
    [SerializeField] Savepoint Savepoint;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.transform.position = Savepoint.Saveposition;
        }

        if(other.gameObject.tag == "OBJ")
        {
            Destroy(other.gameObject);
        }
    }
}
