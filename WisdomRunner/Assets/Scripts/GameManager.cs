using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] GameObject finishLine;
    [SerializeField] GameObject player;
    [SerializeField] PlayerController pcon;
    [SerializeField] Animator anim;

    // Update is called once per frame
    void Update()
    {
        if (isLevelEnd())
        {
            anim.Play("Hip Hop Dancing");
            pcon.runSpeed = 0;
            pcon.xSpeed = 0;
        }
    }
    
    bool isLevelEnd()
    {
        return player.transform.position.z >= finishLine.transform.position.z+1;
    }


}
