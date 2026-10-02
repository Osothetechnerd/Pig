using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    public float speed = 0;
    public int points = 100;
    void Update()
    {
        transform.Translate(-transform.right * speed * Time.deltaTime);

    }
   
       private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Destroy(gameObject);
        }
    }



}


