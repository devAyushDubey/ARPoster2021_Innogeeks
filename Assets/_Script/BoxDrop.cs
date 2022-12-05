using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDrop : MonoBehaviour
{
    public GameObject box1;
    public GameObject box2;
    public GameObject box3;
    public GameObject box4;
    public GameObject box5;
    //public Transform parent;
    //bool[] flag = { true, true, true, true,true };
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.transform.position.x);
        if (gameObject.transform.position.x < 1.0202f && gameObject.transform.position.x > 0.5369f && count == 0) {
            box1.SetActive(true);
            Debug.Log(count);
            count++;
        }

        else if (gameObject.transform.position.x < 0.5369f && gameObject.transform.position.x > 0.0144f && count == 1){
            box2.SetActive(true);
            Debug.Log(count);
            count++;
        }

        else if (gameObject.transform.position.x < 0.0144f && gameObject.transform.position.x > -0.5081f && count == 2)
        {
            box3.SetActive(true);
            Debug.Log(count);
            count++;
        }

        else if (gameObject.transform.position.x < -0.5081f && gameObject.transform.position.x > -1.0306f && count == 3)
        {
            box4.SetActive(true);
            Debug.Log(count);
            count++;
        }

        else if (gameObject.transform.position.x < -1.0306f && count == 4)
        {
            box5.SetActive(true);
            Debug.Log(count);
            count++;
        }



        /*
        else if (gameObject.transform.position.x < 0.0022f && gameObject.transform.position.x > -0.0778f && count == 2){
            GameObject I = Instantiate(box, parent, false);
            count++;
        }
        else if (gameObject.transform.position.x < -0.0778f && gameObject.transform.position.x > -0.1578f && count == 3){
            GameObject I = Instantiate(box, parent, false);
            count++;
        }
        
        else if (gameObject.transform.position.x < -0.1578f && count == 4){
            GameObject I = Instantiate(box, parent, false);
            count++;
        }
        */
    }
}
