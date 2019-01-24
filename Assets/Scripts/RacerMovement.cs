using UnityEngine;

public class RacerMovement : MonoBehaviour {

    // This is a reference to the rigidbody component called "rb"
    public Rigidbody rb;

    // The force to drive the racer forward
    public float forwardForce = 2000f;

    // The force to steer the racer sidways
    public float sidewaysForce = 500f;

    // Variables for improving movement
    private bool movingRight = false;
    private bool movingLeft = false;

    // Update is called once per frame
    // Use fixeUpdate for physics
    void FixedUpdate () {
        // Add a force of forwardForce in the Z-axis
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Ad force if a button is held
        if (movingRight){
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (movingLeft){
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Check if the player has fallen off the edge
        if(rb.position.y < -1) {
            FindObjectOfType<GameManager>().EndGame();
        }
	}

    void Update(){
        // Check if a button is pressed/held
        if (Input.GetKey("d")){
            movingRight = true;
        }
        else{
            movingRight = false;
        }
        if (Input.GetKey("a")){
            movingLeft = true;
        }
        else{
            movingLeft = false;
        }
    }
}
