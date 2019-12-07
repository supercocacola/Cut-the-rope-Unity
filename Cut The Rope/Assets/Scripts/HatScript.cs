using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatScript : MonoBehaviour
{
    public GameObject hat_out;
    public Animation light;
    // Start is called before the first frame update
    void Awake()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Weight")
        {
            //Destroy(collision.gameObject);
            collision.transform.position = new Vector2(hat_out.transform.position.x, 
                                                        hat_out.transform.position.y);
            light.Play();
        }
    }
}
