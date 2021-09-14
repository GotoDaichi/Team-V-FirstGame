using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block2Prefub : MonoBehaviour
{
  Rigidbody2D rigid2D;
    GameObject GameDirector;

    void Start()
    {
    this.rigid2D = GetComponent<Rigidbody2D>();
    this.GameDirector = GameObject.Find("GameDirector");
    }

    // Update is called once per frame
    void Update()
    {
      Vector3 playerPos = transform.position;
    if(Input.GetKeyDown(KeyCode.RightArrow) && this.rigid2D.velocity.y != 0 && playerPos.x <= 2 )
      {
      transform.position = new Vector3(playerPos.x+1.1f,playerPos.y,0);
      }
      if(Input.GetKeyDown(KeyCode.LeftArrow) && this.rigid2D.velocity.y != 0 && playerPos.x >=-2 )
      {
       transform.position = new Vector3(playerPos.x-1.1f,playerPos.y,0);
      }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        GetComponent<Rigidbody2D>().isKinematic = true;
        if(other.gameObject.tag == "block2")
        {
          Destroy(other.gameObject);
          GameDirector.GetComponent<Count>().AddScore();
        }
    }
}
