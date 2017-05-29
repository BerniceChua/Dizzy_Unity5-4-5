using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{

    public Transform target;

    [SerializeField] float m_multiplier = 10;

    DetectPhoneMovements phoneMoves;

    //public float speed = 10.0f;

    Vector3 m_lastPosition = Vector3.zero;
    float m_previousSpeed = 0.0f;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float speedOfGamePiece = GetSpeed();

        transform.RotateAround(target.position, Vector3.up, speedOfGamePiece);
        //transform.RotateAround(target.position, target.up, speedOfGamePiece);
        //transform.RotateAround(target.position, target.up, speedOfGamePiece * Time.deltaTime);
        //transform.RotateAround(target.position, target.up, Input.acceleration.x * Time.deltaTime);
    }

    float GetSpeed()
    {
        /// Input.gyro.userAcceleration.x --- can be used to determine spin direction
        /// --- if positive, it is moving to the right of the screen
        /// --- if negative, it is moving to the left of the screen
        /// 
        /// Input.gyro.userAcceleration.y --- can be used to determine if the player is jumping
        /// --- if positive, the player is moving the phone up
        /// --- if negative, the player is moving the phone down

        /// Need to look for a better substitute for speed.
        /// Input.gyro.attitude.x --- ???? (might need to find better substitute)
        /// --- you need to get the absolute value of this to generate the speed. -- the problem with this is that
        /// --- try adding the absolute value instead of feeding this number directly to multiply, the problem is how do I track

        //float speed = (Input.acceleration - m_previousSpeed).magnitude / Time.deltaTime;
        //float speed = (Input.acceleration.x - m_previousSpeed) * Time.deltaTime;
        //float speed = (Input.gyro.attitude.x - m_previousSpeed) / Time.deltaTime;
        //float speed = Input.gyro.attitude.x;
        //float speed = Input.gyro.userAcceleration.x * m_multiplier;
        float speed = Mathf.Abs(Input.gyro.attitude.x) * m_multiplier;

        //m_previousSpeed = Input.acceleration.x;
        //m_lastPosition = Input.acceleration;
        //m_previousSpeed = Input.gyro.attitude.x;
        //m_previousSpeed = Input.gyro.userAcceleration.x * m_multiplier;
        m_previousSpeed = Mathf.Abs(Input.gyro.attitude.x) * m_multiplier;

        //return speed * m_multiplier;
        return speed;
    }
}