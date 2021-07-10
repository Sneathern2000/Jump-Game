using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage_level : MonoBehaviour
{
    public int Level;
    // Start is called before the first frame update
    void Start()
    {
        Level = 0; // 0=ムービー　1=チュートリアル 2=ステージ1　3=ステージ２ 4=ステージ3 etc...

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
