using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 500f;
    public float acceleration = 5f;
    public float sidewaysForce = 500f;
    public float retardForce = 100f;
    void start()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
    }

    // Update is called once per frame
    void FixedUpdate () {
        float frames = 0;
        if (frames < 360)
            frames = 360;
        frames = frames+ (10 * Time.deltaTime);
        rb.AddForce(0, 0, forwardForce * Time.deltaTime*acceleration*frames/250f);




        if(Input.GetKey("d")){
            rb.AddForce(sidewaysForce * Time.deltaTime,0,-(retardForce) * Time.deltaTime,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-(sidewaysForce) * Time.deltaTime,0, -(retardForce) * Time.deltaTime, ForceMode.VelocityChange);
        }


        if (rb.position.y<0f)
        {
            FindObjectOfType<PlayerMovement>().enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            FindObjectOfType<Score>().enabled = false;
        }
        if(Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
        Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            if (touchPosition.y >= 0f){
rb.AddForce(sidewaysForce* Time.deltaTime, 0, -(retardForce) * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (touchPosition.y< 0f)
        {
            rb.AddForce(-(sidewaysForce) * Time.deltaTime, 0, -(retardForce) * Time.deltaTime, ForceMode.VelocityChange);
        }
        }
    }
}
