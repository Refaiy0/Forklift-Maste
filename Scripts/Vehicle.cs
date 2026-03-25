using UnityEngine;
using UnityEngine.UIElements;


public class Vehicle : MonoBehaviour
{
    public float speed;
    private float VmoveInput;

    private float turnInput;
    public float TourqeSpeed;


    public float CenterofMass;

    private Rigidbody rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }
    void Start()
    {
       rb.centerOfMass = new Vector3(0, CenterofMass, 0);

    }

    void Update()
    {

        VmoveInput = Input.GetAxis("Vertical");
        turnInput = Input.GetAxis("Horizontal");
       
        if (transform.position.y < -3.5f) 
        {
            GameManager.instance.gameOverScreen();
        }
        
    }

    void FixedUpdate()
    {
        if (VmoveInput != 0f)
        {
            rb.AddForce(transform.forward * VmoveInput * speed * Time.deltaTime,ForceMode.Acceleration);
            AudioManager.instance.VehicleSound(true);

            //Debug.Log("move forward");
        }
        //for Sounds
        if (VmoveInput == 0f)
        {
           AudioManager.instance.VehicleSound(false);

        }
        if (turnInput != 0f) 
        {
            transform.RotateAround(transform.position, turnInput * Vector3.up, TourqeSpeed * Time.deltaTime);
            //Debug.Log("turned");


        }


    }





}
