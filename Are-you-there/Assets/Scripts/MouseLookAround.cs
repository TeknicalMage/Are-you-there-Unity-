using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookAround : MonoBehaviour
{

    public GameObject Camera;

    public bool CamState = false;  

    Vector3 newRotation = new Vector3(0f, -42f, 0f);

    public GameObject m_CameraObject;

    [SerializeField]
    private float _mouseSensitivity = 3.0f;

    private float _rotationY;
    private float _rotationX;

    void Update(){
        
        //currentEulerAngles = new Vector3(0.0f, 42.247f, -0.0f);
        //currentRotation.eulerAngles = currentEulerAngles;
        
        if(CamState){
            if (m_CameraObject.tag == "LeftHandCamera")
            {
                transform.localEulerAngles = new Vector3(0, -42, 0);
                Camera.transform.position = new Vector3(0.162f, 3.065f, -10.0379f);
            }
            else if (m_CameraObject.tag == "RightHandCamera")
            {
                transform.localEulerAngles = new Vector3(0, 30, 0);
                Camera.transform.position = new Vector3(0.94f, 3.065f, -9.98f);
            }
            else if (m_CameraObject.tag == "TelephoneCamera")
            {
                transform.localEulerAngles = new Vector3(27.635f, 60.536f, 4.288f);
                Camera.transform.position = new Vector3(2.22f, 2.71f, -10.69f);
            }
        } else {
            transform.localEulerAngles = new Vector3(_rotationX, _rotationY, 0);
            Camera.transform.position = new Vector3(0.752f, 2.77f , -11.32f);  
            Cursor.lockState = CursorLockMode.Locked;
            float mouseX = Input.GetAxis("Mouse X") * _mouseSensitivity;
            float mouseY = Input.GetAxis("Mouse Y") * -1 * _mouseSensitivity;

            _rotationY += mouseX;
            _rotationX += mouseY;
            
        }




        
            }


}
