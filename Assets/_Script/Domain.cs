using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class Domain : MonoBehaviour
{
    public GameObject Star;
    public GameObject Credit;
    public GameObject Drone;
    public VideoPlayer introvd;
    public GameObject domainvd;
    //public GameObject Canvass;
    public GameObject BackBut;
    public Material UFOmat;
    public GameObject ufoo;
    public bool flag = false;
    public VideoClip AR;
    public VideoClip Android;
    public VideoClip Web;
    public VideoClip ML;
    public VideoClip iot;
    public GameObject exxit;
    /*public Animator s1;
    public Animator s2;
    public Animator s3;
    public Animator s4;
    public Animator s5;
    public Animator s6;*/
    public Storage st;

    int TagToIndex(string tag)
    {
        if (tag == "AR")
            return 2;
        else if (tag == "Android")
            return 3;
        else if (tag == "Web")
            return 4;
        else if (tag == "ML")
            return 5;
        else if (tag == "iot")
            return 6;
        else
            return 6;
    }

    void ufo()
    {
        if(st.ptap != "-1")
            ufoo.transform.GetChild(TagToIndex(st.ptap)).gameObject.SetActive(false);
        if(st.tap != "Back")
            ufoo.transform.GetChild(TagToIndex(st.tap)).gameObject.SetActive(true);

        switch (st.tap)
        {
            case ("AR"):{
                    domainvd.GetComponent<VideoPlayer>().clip = AR;
                    UFOmat.color = new Color(195, 204, 198);
                    break;
            }
            case ("Android"):
                {
                    domainvd.GetComponent<VideoPlayer>().clip = Android;
                    UFOmat.color = new Color(0, 255, 85);
                    break;
                }
            case ("Web"):
                {
                    domainvd.GetComponent<VideoPlayer>().clip = Web;
                    UFOmat.color = new Color(212, 87, 0);
                    break;
                }
            case ("ML"):
                {
                    domainvd.GetComponent<VideoPlayer>().clip = ML;
                    UFOmat.color = new Color(141, 2, 222);
                    break;
                }
            case ("iot"):
                {
                    domainvd.GetComponent<VideoPlayer>().clip = iot;
                    UFOmat.color = new Color(1, 213, 221);
                    break;
                }

        }
    }
    /*public void Click()
    {
        Debug.Log("Clicked");
    }*/
    void OnMouseDown()
    {
        if (st.tap != "0")
        {
            st.ptap = st.tap;

        }
        st.tap = gameObject.tag;
        Debug.Log("Clicked");
        flag = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        Animator Droneanim = Drone.GetComponent<Animator>();
        //Debug.Log("Clicked");
        /*
        s1 = s1.GetComponent<Animator>();
        s2 = s2.GetComponent<Animator>();
        s3 = s3.GetComponent<Animator>();
        s4 = s4.GetComponent<Animator>();
        s5 = s5.GetComponent<Animator>();
        s6 = s6.GetComponent<Animator>();*/
    }

    // Update is called once per frame
    void Update()
    {

        if (flag == true)
        {
            Animator Droneanim = Drone.GetComponent<Animator>();

            if (st.tap == "Back")
            {
                if(ufoo.activeInHierarchy == true)
                    ufoo.GetComponent<Animator>().Play("UFOExit");
                Droneanim.Play("Empty");
                introvd.playbackSpeed = 1;
                domainvd.SetActive(false);
                BackBut.SetActive(false);
                Credit.SetActive(true);
                Credit.GetComponent<Animator>().Play("Empty");
                Star.SetActive(false);
                st.flag = true;
            }
            else if (st.ptap == "-1" || st.ptap == "Back")
            {
                Credit.SetActive(false);
                //Debug.Log("THis Condition");
                exxit.SetActive(false);
                ufoo.SetActive(true);
                if (st.ptap == "Back")
                    ufoo.GetComponent<Animator>().Play("UFOEntry");
                Droneanim.Play("Exit");
                //ufoo.transform.GetChild(TagToIndex(st.tap)).gameObject.SetActive(true);
                domainvd.SetActive(true);
                BackBut.SetActive(true);
                introvd.playbackSpeed = 0.0f;
                ufo();
            }

            if (st.ptap != "-1" && st.ptap != "Back" && st.ptap != "Credit")
            {
                GameObject vari = GameObject.FindGameObjectWithTag(st.ptap);
                vari.transform.localScale = new Vector3(0.224f, 0.224f, 0.224f);
                ufo();

            }

            if (st.tap != "Back")
            {
                if (exxit.activeInHierarchy == true)
                    exxit.SetActive(false);
                GameObject var = GameObject.FindGameObjectWithTag(st.tap);
                var.transform.localScale = new Vector3(0.28f, 0.28f, 0.28f);
                Credit.SetActive(false);
            }
            
            flag = false;
        }

    
        /*
        if (tap != "0")
        {
            s1.Play("SE1");
            s2.Play("SE2");
            s3.Play("SE3");
            s4.Play("SE4");
            s5.Play("SE5");
            s6.Play("SE6");
        }
        */
    }
}
