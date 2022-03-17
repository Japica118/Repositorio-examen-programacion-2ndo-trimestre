using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    
Player _player;

   void Awake()
   {
       _player = GameObject.Find("Mario_0").GetComponent<Player>();
   }

    void OnTriggerStay2D(Collider2D collider)
    {
        _player.isGrounded = true;
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        _player.isGrounded = false;
    }
}
