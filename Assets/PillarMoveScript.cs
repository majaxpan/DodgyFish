using UnityEngine;

public class PillarMoveScript : MonoBehaviour
{

    public float moveSpeed = 5; //-> 5 units per second (not per frame)
    public float deadZone = -15;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe deleted.");
            Destroy(gameObject);
        }
    }
}
