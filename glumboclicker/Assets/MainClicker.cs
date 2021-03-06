using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainClicker : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Camera mainCam;
    [SerializeField] GlumboCoin coin;
    [SerializeField] PhoneClick phone;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Ray camRay = mainCam.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f));
            RaycastHit hitRay;
            Physics.Raycast(camRay, out hitRay);
            if (hitRay.collider != null)
            {
                switch (hitRay.collider.tag)
                {
                    case "Glumbocoin":
                        coin.Spin();
                        break;
                    default: break;
                }
            }
        }
        else
        {
            Ray camRay = mainCam.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f));
            RaycastHit hitRay;
            Physics.Raycast(camRay, out hitRay);
            if (hitRay.collider != null)
            {
                switch (hitRay.collider.tag)
                {
                    case "Glumbocoin":
                        //glow the coin?
                        break;
                    case "Phone":
                        phone.MouseHover(hitRay.point);
                        break;
                    default: break;
                }
            }
        }
    }
}
