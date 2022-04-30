using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainClicker : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Camera mainCam;
    [SerializeField] GlumboCoin coin;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetMouseButtonDown(0)){
         
        Ray camRay = mainCam.ScreenPointToRay(new Vector3(Input.mousePosition.x,Input.mousePosition.y,0f));
        RaycastHit hitRay;
        Physics.Raycast(camRay, out hitRay);
        if(hitRay.collider!=null){
            if(hitRay.collider.tag=="Glumbocoin")
                coin.Spin();
            }   
        }        
    }
    
}
