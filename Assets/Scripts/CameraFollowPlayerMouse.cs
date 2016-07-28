using UnityEngine;
using System.Collections;

public class CameraFollowPlayerMouse : MonoBehaviour {
    public Transform playerLoc;

    private float smoothTime = 0.3f;

    private Vector3 velocity = Vector3.zero;

    void Update()
    {
        Vector3 goalPos = playerLoc.position;

        goalPos.z = transform.position.z;
        transform.position = Vector3.SmoothDamp(transform.position, goalPos, ref velocity, smoothTime);
    }
}
