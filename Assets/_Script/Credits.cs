using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Credits : MonoBehaviour
{
    public GameObject Drone;
    public VideoPlayer introvid;
    //public GameObject caan;
    //public GameObject buttonn;
    public GameObject Back;
    public GameObject po1;
    public GameObject po2;
    public GameObject po3;
    public GameObject po4;
    public GameObject po5;
    public GameObject star;
    public GameObject exxit;
    public Storage st;

    private void OnMouseDown()
    {
        st.tap = "Credit";
        exxit.SetActive(false);


        //gameObject.GetComponent<Animator>().Play("Credits");
        gameObject.transform.GetChild(0).GetComponent<Light>().intensity = 15f;
        Drone.GetComponent<Animator>().Play("Exit");

        introvid.playbackSpeed = 0f;
        //caan.SetActive(false);
        Back.SetActive(true);
        //buttonn.SetActive(false);
        po1.SetActive(false);
        po2.SetActive(false);
        po3.SetActive(false);
        po4.SetActive(false);
        po5.SetActive(false);
        //Ach.SetActive(false);
        star.SetActive(true);
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
