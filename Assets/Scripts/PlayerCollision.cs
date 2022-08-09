using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameManager gm;

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Enemy")
        {
            gm.EndGame();
        }
    }
}
