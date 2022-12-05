using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TrackPause : MonoBehaviour
{
    public Storage st;
    public bool trig;
    public VideoPlayer vd1;
    public VideoPlayer vd2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(vd1.isPlaying);
        Debug.Log(vd2.isPlaying);
        //if()
    }
}
