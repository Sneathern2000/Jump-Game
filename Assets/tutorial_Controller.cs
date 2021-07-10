using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial_Controller : MonoBehaviour
{
    [SerializeField] private Stage_level stage_Level;
    public int move;
    [SerializeField] Liner frontwall;
    [SerializeField] Liner Buckwall;
    [SerializeField] Liner leftwall;
    [SerializeField] Liner rightwall;
    [SerializeField] Liner monitor;
    [SerializeField] Liner[] Objects;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(stage_Level.Level == 1 && move == 0)move = 1;
        if (Input.GetKeyDown(KeyCode.Alpha2)) move = 2;
        if(move == 1)
        {
            
        }

        if(move == 2)
        {
            frontwall.endPosition = new Vector3(-255.3f, -28.6f, 82.9f);
            monitor.endPosition = new Vector3(-255.3f, -23.5f, 104.9f);
            Buckwall.endPosition = new Vector3(-254, -28.6f, 128.1f);
            frontwall.enabled = true;
            Buckwall.enabled = true;
            monitor.enabled = true;
        }
        if(move== 3)
        {
            Objects[0].enabled = true;
            Objects[1].enabled = true;
            Objects[2].enabled = true;
        }
    }
}
