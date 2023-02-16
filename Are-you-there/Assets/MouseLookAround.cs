using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookAround : MonoBehaviour
{
    [SerializeField]
    private float _mouseSensitivity = 3.0f;

    private float _rotationY;
    private float _rotationX;

    void Update(){
        Cursor.lockState = CursorLockMode.Locked;
        float mouseX = Input.GetAxis("Mouse X") * _mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * -1 * _mouseSensitivity;

        _rotationY += mouseX;
        _rotationX += mouseY;


        transform.localEulerAngles = new Vector3(_rotationX, _rotationY, 0);




        
            }


}
