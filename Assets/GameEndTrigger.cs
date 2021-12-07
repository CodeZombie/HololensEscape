using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GameEndTrigger : MonoBehaviourPun
{
    public GameObject FlagPole;
    public GameObject Player;
    private bool levelOver = false;
    private float startTime;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (!levelOver)
        {
            if (Vector3.Distance(FlagPole.transform.localPosition, Player.transform.localPosition) < 2.0)
            {
                this.photonView.RPC("GameOver", RpcTarget.All, Time.time - startTime);
                levelOver = true;
            }
        }
    }
}
