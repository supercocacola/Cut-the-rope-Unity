using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatAction : MonoBehaviour
{
    public GameObject weight;
    public GameObject frog;
    public GameObject star;
    public GameObject spike;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        Vector2 temp = weight.transform.position;
        Vector2 temp1 = frog.transform.position;
        Vector2 temp2 = star.transform.position;
        Vector2 temp3 = spike.transform.position;
        if (temp.x > temp1.x)
        {
            weight.SetActive(false);
        }
        if (temp.x > temp2.x)
        {
            star.SetActive(false);
        }
        if (temp.y <= temp3.y)
        {
            //DestroyObject(weight);
            weight.SetActive(false);
        }
    }
}
