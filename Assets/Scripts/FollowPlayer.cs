using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform racer;
    public Vector3 offset;

	// Update is called once per frame
	void Update () {
        transform.position = racer.position + offset;
	}
}
