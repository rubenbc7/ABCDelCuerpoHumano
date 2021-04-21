using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanZoom : MonoBehaviour
{
    Vector3 touchStart;
    public float zoomOutMin = 0.1f;
    public float zoomOutMax = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   float posicionx = Camera.main.transform.position.x;
        float posiciony = Camera.main.transform.position.y;
        float posicionz = Camera.main.transform.position.z;
    

        if(posicionx <= -0.45f){
              Camera.main.transform.position = new Vector3(-0.420f, posiciony, posicionz);
        }

        if(posicionx >= 0.45f){
              Camera.main.transform.position = new Vector3(0.420f, posiciony, posicionz);
        }
                           
        if(posiciony >= 1.65f){
              Camera.main.transform.position = new Vector3(posicionx, 1.64f, posicionz);
        }       

        if(posiciony <= 0.25f){
              Camera.main.transform.position = new Vector3(posicionx, 0.26f, posicionz);
        }           
            
            if(Input.GetMouseButtonDown(0)){
                touchStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                }
            if(Input.touchCount == 2){
                Touch touchZero = Input.GetTouch(0);
                Touch touchOne = Input.GetTouch(1);

                Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
                Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

                float prevMagnitude = (touchZeroPrevPos - touchOnePrevPos).magnitude;
                float currentMagnitude = (touchZero.position - touchOne.position).magnitude;

                float difference = currentMagnitude - prevMagnitude;

                zoom(difference * 0.001f);
            }
            else if(Input.GetMouseButton(0)){
                Vector3 direction = touchStart - Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Camera.main.transform.position += direction;
            }
            zoom(Input.GetAxis("Mouse ScrollWheel"));
    }

    
    


    void zoom(float increment){
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize - increment, zoomOutMin, zoomOutMax);
    }
}
