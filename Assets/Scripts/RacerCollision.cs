using UnityEngine;

public class RacerCollision : MonoBehaviour {

    public RacerMovement movement;

    //Disabling gravity and launching boxes
    public Rigidbody player;
    public float upwardsForce;

	void OnCollisionEnter(Collision collisionInfo){
        if(collisionInfo.collider.tag == "Obstacle"){
            movement.enabled = false;

            //Disabling gravity and launching boxes
            player.useGravity = false;
            player.AddForce(0, upwardsForce, 0);

            collisionInfo.gameObject.GetComponent<Rigidbody>().useGravity = false;
            collisionInfo.gameObject.GetComponent<Rigidbody>().AddForce(0, upwardsForce, 0);

            //End game
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
