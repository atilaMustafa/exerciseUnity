using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

  bool hasPackage;

  void OnCollisionEnter2D(Collision2D other)
  {
    Debug.Log("OUCH!!"); 
  }

  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag=="Package"&& hasPackage==false)
    {
      Debug.Log("package picked up ");
      hasPackage = true;
      Destroy(other.gameObject, 0.3f) ;

    }

    if (other.tag=="Customer" && hasPackage== true )
    {

      Debug.Log("delivered");

      hasPackage= false;

    }

  }

}
