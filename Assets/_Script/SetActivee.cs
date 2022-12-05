using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class SetActivee : MonoBehaviour
{
    int count = 1;
    int pcount = 1;
    //public DefaultTrackableEventHandler D;
    public float timer = 0;
    public float box1;
    public float box2;
    public float box3;
    public float box4;
    public float box5;
    //public GameObject Drone;
    public GameObject box_1;
    public GameObject box_2;
    public GameObject box_3;
    public GameObject box_4;
    public GameObject box_5;
    public GameObject p_1;
    public GameObject p_2;
    public GameObject p_3;
    public GameObject p_4;
    public GameObject p_5;
    public GameObject po_1;
    public GameObject po_2;
    public GameObject po_3;
    public GameObject po_4;
    public GameObject po_5;
    public GameObject Credit;
    public GameObject Achievement;
    public GameObject Back;
    public GameObject exxit;
    public GameObject website;
    public Storage st;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(gameObject.GetComponent<DefaultTrackableEventHandler>().tracking);
        if(gameObject.GetComponent<DefaultTrackableEventHandler>().tracking == true)
            timer += Time.deltaTime;

        if(st.flag == true)
        {
            po_1.SetActive(true);
            po_2.SetActive(true);
            po_3.SetActive(true);
            po_4.SetActive(true);
            po_5.SetActive(true);
            //Achievement.GetComponent<Animator>().Play("Empty");
            //Achievement.SetActive(true);
            exxit.SetActive(true);
            st.flag = false;
            Debug.Log("SetActive says hi");
        }


        if (timer > box1 + 3 && timer < box1 + 3 + 0.2f && pcount == 1)
        {
            p_1.SetActive(true);
            pcount++;
            box_1.SetActive(false);
            po_1.SetActive(true);
        }
        if (timer > box2 + 3 && timer < box2 + 3 + 0.2f && pcount == 2)
        {
            p_2.SetActive(true);
            pcount++;
            box_2.SetActive(false);
            po_2.SetActive(true);
        }
        if (timer > box3 + 3 && timer < box3 + 3 + 0.2f && pcount == 3)
        {
            p_3.SetActive(true);
            pcount++;
            box_3.SetActive(false);
            po_3.SetActive(true);
        }
        if (timer > box4 + 3 && timer < box4 + 3 + 0.2f && pcount == 4)
        {
            p_4.SetActive(true);
            pcount++;
            box_4.SetActive(false);
            po_4.SetActive(true);
            Credit.SetActive(true);
            website.SetActive(true);
            //Achievement.SetActive(true);
            exxit.SetActive(true);
        }
        if (timer > box5 + 3 && timer < box5 + 3 + 0.2f && pcount == 5)
        {
            p_5.SetActive(true);
            pcount++;
            box_5.SetActive(false);
            po_5.SetActive(true);
        }

        if (timer > box1 && timer < box1 + 0.2f && count == 1){ 
            box_1.SetActive(true);
            count++;
        }
        else if(timer > box2 && timer<box2+0.2f && count == 2){
            box_2.SetActive(true);
            count++;
        }
        else if (timer > box3 && timer < box3 + 0.2f && count == 3)
        {
            box_3.SetActive(true);
            count++;
        }
        else if (timer > box4 && timer < box4 + 0.2f && count == 4)
        {
            box_4.SetActive(true);
            count++;
        }
        else if (timer > box5 && timer < box5 + 0.2f && count == 5)
        {
            box_5.SetActive(true);
            count++;
        }


        //Debug.Log(timer);
    }
}
