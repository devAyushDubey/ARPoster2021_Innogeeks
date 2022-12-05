using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hyper_2 : MonoBehaviour
{
    public string namee;
    private void OnMouseDown()
    {
        namee = gameObject.name;
        Debug.Log(namee);
        switch (namee)
        {
            case "11":
                {
                    Application.OpenURL("https://www.instagram.com/anupam_1603/");
                    break;
                }
            case "12":
                {
                    Application.OpenURL("https://www.linkedin.com/in/anupam-tiwari-b9685b207/");
                    break;
                }
            case "21":
                {
                    Application.OpenURL("https://www.instagram.com/arshiva_astha/");
                    break;
                }
            case "22":
                {
                    Application.OpenURL("https://www.linkedin.com/in/astha-850ba6201/");
                    break;
                }
            case "31":
                {
                    Application.OpenURL("https://www.instagram.com/_iam.ayush_/");
                    break;
                }
            case "32":
                {
                    Application.OpenURL("https://www.linkedin.com/in/ayush-dubey-/");
                    break;
                }
            case "41":
                {
                    Application.OpenURL("https://www.instagram.com/kritish_10/");
                    break;
                }
            case "42":
                {
                    Application.OpenURL("https://www.linkedin.com/in/kritish-shukla-805902210/");
                    break;
                }
            case "51":
                {
                    Application.OpenURL("https://www.instagram.com/im_vidushi2615/");
                    break;
                }
            case "52":
                {
                    Application.OpenURL("https://www.linkedin.com/in/vidushi-pandey-24007b1b2/");
                    break;
                }
            case "61":
                {
                    Application.OpenURL("https://instagram.com/_iam.ayush_/");
                    break;
                }
            case "62":
                {
                    Application.OpenURL("https://instagram.com/_iam.ayush_/");
                    break;

                }

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
