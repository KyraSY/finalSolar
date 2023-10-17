using UnityEngine;

public class MoveRocket : MonoBehaviour
{
    public float speed = .01f;
    // Update is called once per frame
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal"); //Collects input data and moves object left or right based on key pushed
        float zDirection = Input.GetAxis("Vertical");   // Collects input data and moves object up or down based on key pushed
        float yDirection = 0.0f;
        if (Input.GetKey("x")) {
            yDirection = -1.0f;
        } else if (Input.GetKey("z")) {
            yDirection = 1.0f;
        }
        //Vector 3 is a variable that takes in three x, y ,z inputs-will help to make a movement vector
        Vector3 moveDirection = new Vector3(xDirection, yDirection, zDirection); //Y input or vertical input into z place as if up or down is pushed we want the object to move forwards or backwards
       
        transform.position += moveDirection * speed;
    }
}
