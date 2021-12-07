using Microsoft.MixedReality.Toolkit.Utilities.Solvers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FadeOut : MonoBehaviour
{
    private float startTime;
    private bool finishedFadingOut = false;

    public RawImage imageToFadeOut;
    public GameObject roomPlate;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        roomPlate.transform.position = new Vector3(0, 0, 35.0f);
        roomPlate.GetComponent<Follow>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - startTime > 3 && !finishedFadingOut)
        {
            if(imageToFadeOut.color.a > 0)
            {
                Color newColor = imageToFadeOut.color;
                newColor.a -= 0.01f;
                imageToFadeOut.color = newColor;
            }
            else
            {
                Color newColor = imageToFadeOut.color;
                newColor.a = 0.0f;
                imageToFadeOut.color = newColor;

                roomPlate.GetComponent<Follow>().enabled = true;
                finishedFadingOut = true;
            }
            

        }
    }
}
