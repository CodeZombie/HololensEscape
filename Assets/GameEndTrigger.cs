using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GameEndTrigger : MonoBehaviourPun
{
    public GameObject FlagPole;
    public GameObject Player;
    private bool levelOver = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!levelOver)
        {
            if (Vector3.Distance(FlagPole.transform.position, Player.transform.position) < 2.0)
            {
                Debug.Log("LEVEL OVER");
                this.photonView.RPC("GameOver", RpcTarget.All);
                levelOver = true;
            }
        }
    }
}
