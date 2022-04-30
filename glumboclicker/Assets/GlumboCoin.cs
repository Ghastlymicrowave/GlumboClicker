using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlumboCoin : MonoBehaviour
{
    [SerializeField]float accel = 0.5f;
    [SerializeField]float decel = 0.1f;
    [SerializeField]float staticF = 5f;
    [SerializeField]float lerpSpd = 0.1f;
    float currentSpd = 0f;
    float rot = 0f;
    void Start(){
        UpdateTransform();
    }

    public void Spin(){
        currentSpd += accel;
    }
    private void UpdateTransform(){
        transform.rotation = Quaternion.Euler(0f,rot+180,0f);
    }
    void Update()
    {
        if(currentSpd>0){
            rot += currentSpd * Time.deltaTime;
            currentSpd -= currentSpd * decel * Time.deltaTime;
            rot%=360;
            UpdateTransform();
            if(currentSpd <= staticF){
                currentSpd = 0f;
            }
        }else{
            if(Mathf.Abs(Mathf.DeltaAngle(rot%=360, 0f))>1f){
                rot = Mathf.Lerp(rot, 360f,lerpSpd);
                UpdateTransform();
            }else{
                rot = 0f;
                UpdateTransform();
            }
        }
    }
}
