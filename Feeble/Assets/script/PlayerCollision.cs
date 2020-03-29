
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovementController playerMovementController ;

    void OnCollisionEnter(Collision collisionInfo)
    {
        
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log(collisionInfo.collider.name);
        }
    }
}
 