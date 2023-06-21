using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< Updated upstream
public class CameraMovement : MonoBehaviour
{
    // declare a new object called target to later assign to another object to follow
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // every frame, transform the position to the targets x ,keep the y the same, and set the z to -10.
        transform.position = new Vector3(target.transform.position.x, transform.position.y, -10);
    }
}
=======
public class Camera : MonoBehaviour
{
    public GameObject target;
    //start is called before the first frame update
    void Start()
    {

    }

    //Update is called once per frame
    void Update()
    {
        // make the camera follow the character X positin, and keep the Y static (unchanging)
        transform.position = new Vector3(target.transform.position.x, transform.position.y, -10);
    }

}
>>>>>>> Stashed changes
