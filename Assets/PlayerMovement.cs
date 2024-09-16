using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 5.0f;
    [SerializeField] GameObject enemy;
    [SerializeField] bool moveClockwise = true;

    float angle = 0f;

    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // Player code
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        // Enemy code
        float radiusOffset = (this.transform.position - enemy.transform.position).magnitude;
        float direction = moveClockwise ? -1 : 1;
        angle += Time.deltaTime * direction * speed;

        float x = Mathf.Cos(angle) * radiusOffset;
        float y = Mathf.Sin(angle) * radiusOffset;

        enemy.transform.position = new Vector3(this.transform.position.x + x, this.transform.position.y + y, 0);
    }
}
