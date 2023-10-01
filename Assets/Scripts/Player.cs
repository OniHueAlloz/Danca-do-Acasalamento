using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody2D rb;
    public int count;
    public int i;
    private bool giro = false;
    public ParticleSystem Coracoes; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        count = 0;
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

	Vector2 movement = new Vector2(horizontal, 0);
	rb.velocity = movement*speed;

        if (count >= 2){
          Coracoes.Play();
        }
    }

   void OnTriggerStay2D(Collider2D collisionInfo){
     if(collisionInfo.gameObject.tag == "Inimigo"){
       if (Input.GetKeyDown(KeyCode.Space)){ 
         float lado = giro ? -1f : 1f;
         collisionInfo.gameObject.transform.localScale = new Vector3(lado,1f,1f);
         gameObject.transform.localScale = new Vector3(lado,1f,1f);
         giro = !giro;
         if (i >= 2) {
           collisionInfo.gameObject.SetActive(false);
           count ++;
           i = 0;
         }
         i++;
       }
     }
     
   }
}
