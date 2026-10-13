using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float startPos, length;
    public GameObject cam;
    public float parallaxEffect; //speed that background should move at in relativity to camera
    void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        // calculates the distance background moves in relativity to the camera movement
        float distance = cam.transform.position.x * parallaxEffect; // 0 = move with cam, 0.5 = half move 1 = will not move. LOWER IT IS FASTER IT MOVES
        float movement = cam.transform.position.x * (1 - parallaxEffect);

        transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);

        // when the background reaches the end of its length position is adjusted to create an infinite scroll
        if (movement > startPos + length)
        {
            startPos += length;
        }
        else if (movement < startPos - length)
        {
            startPos -= length;
        }
    }
}
