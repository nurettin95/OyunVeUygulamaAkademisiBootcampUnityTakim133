using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject finishLine;
    [SerializeField] GameObject player;
    [SerializeField] PlayerController pctrl;
    [SerializeField] Animator anim;
    [SerializeField] GameObject levelEndUI;

    // Update is called once per frame
    void Update()
    {
        if (isLevelEnd())
        {
            anim.Play("Hip Hop Dancing");
            pctrl.runSpeed = 0;
            pctrl.xSpeed = 0;
            levelEndUI.SetActive(true);
        }
    }
    
    bool isLevelEnd()
    {
        return player.transform.position.z >= finishLine.transform.position.z+1;
    }


}
