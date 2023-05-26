using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullAbillity : MonoBehaviour, IPull
{
    [SerializeField] private Rigidbody rigidbody;
    [SerializeField] private float axisX = 0f, axisY = 0f, axisZ = 0f;
    [Header("Указать точки-датчики контакта с GND")]
    [SerializeField] private Transform[] pointGnd;
    [Header("Указать слой GND")]
    [SerializeField] LayerMask groundLayer;
    public float ShootDelay;
    private float shootTime = float.MinValue;
    public void Jamp()
    {
        if (Time.time < shootTime + ShootDelay)
        {
            return;
        }
        else
        {
            shootTime = Time.time;
        }

        if (GndControl())
        {
            //flagStopJump = false;
            Vector3 tempVector = new Vector3(axisX, axisY, axisZ);
            rigidbody.AddForce(tempVector, ForceMode.Impulse);
        }
        
    }
    private bool GndControl()
    {
        for (int i = 0; i < pointGnd.Length; i++)//переберем все точки-датчики контакта с GND
        {
            Debug.Log(Physics.CheckSphere(pointGnd[i].position, 0.1f, groundLayer, QueryTriggerInteraction.Ignore));
            if (Physics.CheckSphere(pointGnd[i].position, 0.1f, groundLayer, QueryTriggerInteraction.Ignore))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        return true;    
    }
}