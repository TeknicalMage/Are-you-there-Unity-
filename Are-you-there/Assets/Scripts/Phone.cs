using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour
{
    AudioSource Phoneoff;

    public GameObject Cam;

    //Locked in positon of the Camera
    Vector3 PhoneLoc = new Vector3(2.22f, 2.71f, -10.69f);

    // Start is called before the first frame update
    void Start()
    {
        
        //print("Phone Doing a Thing");
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Cam.transform.position == PhoneLoc){
            if (Input.GetMouseButtonDown(0)){
            print("Anwser Call");
            FindObjectOfType<AudioManager>().Play("office_phone");
            }

            
        if (Input.GetMouseButtonDown(1)){
            print("Hang Up");
            FindObjectOfType<AudioManager>().Stop("office_phone");
        }

            

        } 
        
        
    }
}
