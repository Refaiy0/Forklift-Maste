using UnityEngine;

public class ForkController : MonoBehaviour
{
    public float speed;
    public double MaxHeight;
    public double MinHeight;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButton(1)) 
        {
            if (transform.localPosition.y <= MaxHeight)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
                //Debug.Log("right");
            }
        }

            else if (Input.GetMouseButton(0)) 
            {
                if (transform.localPosition.y >= MinHeight) 
                {
                    transform.Translate(Vector3.down * speed * Time.deltaTime); // down is -1 btw >o<
                   // Debug.Log("down");
                }


            }
            
           
        
    }
}
