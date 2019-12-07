using UnityEngine;

public class Weight : MonoBehaviour {

	public float distanceFromChainEnd = 0.6f;
    public GameObject weight;
    public Animator frog;

	public void ConnectRopeEnd (Rigidbody2D endRB)
	{
		HingeJoint2D joint = gameObject.AddComponent<HingeJoint2D>();
		joint.autoConfigureConnectedAnchor = false;
		joint.connectedBody = endRB;
		joint.anchor = Vector2.zero;
		joint.connectedAnchor = new Vector2(0f, -distanceFromChainEnd);
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Spike")
        {
            Destroy(weight);
        }
        if (collision.tag == "Frog")
        {
            Destroy(weight);
            frog.SetBool("isEat", true);
        }
        if (collision.tag == "Star")
        {
            Destroy(collision.gameObject);
        }
    }

}
