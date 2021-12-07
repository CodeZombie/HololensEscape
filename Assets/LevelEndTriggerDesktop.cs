using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
using UnityEngine.UI;
public class LevelEndTriggerDesktop : MonoBehaviourPun
{
    public GameObject LevelEndContentContainer;
    public string NextLevelName;
    public float startTime;
    public TextMeshPro textMeshPro;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        LevelEndContentContainer.SetActive(false);
    }
    
    [PunRPC]
    void GameStart()
    {
        startTime = Time.time;
    }

    [PunRPC]
    void GameOver()
    {
        LevelEndContentContainer.SetActive(true);
        StartCoroutine(ChangeLevel(NextLevelName));
        if(textMeshPro != null)
        {
            textMeshPro.text = "Complete in " + Mathf.Floor(Time.time - startTime).ToString() + "s";
        }
        if(text != null)
        {
            text.text = "Complete in " + Mathf.Floor(Time.time - startTime).ToString() + "s";
        }
    }

    IEnumerator ChangeLevel(string levelname)
    {
        yield return new WaitForSeconds(3);
        Debug.Log("CHANGING LEVEL TO " + levelname);
    }
}
