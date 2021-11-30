using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class LevelEndTriggerDesktop : MonoBehaviourPun
{
    public GameObject LevelEndContentContainer;
    public string NextLevelName;
    // Start is called before the first frame update
    void Start()
    {
        LevelEndContentContainer.SetActive(false);
    }

    [PunRPC]
    void GameOver()
    {
        LevelEndContentContainer.SetActive(true);
        StartCoroutine(ChangeLevel(NextLevelName));
    }

    IEnumerator ChangeLevel(string levelname)
    {
        yield return new WaitForSeconds(3);
        Debug.Log("CHANGING LEVEL TO " + levelname);
    }
}
