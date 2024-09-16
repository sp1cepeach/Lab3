using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float speed = 4f;
    // player object
    [SerializeField] GameObject main;
    [SerializeField] bool moveClockwise = true;
    [SerializeField] float radiusOffset;

    float angle = 0f;
    float direction = -1f;
    Vector3 mainPosition;


    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        //radiusOffset = (mainPosition - this.transform.position).magnitude;
        //mainPosition = main.transform.position;
        //direction = moveClockwise ? -1 : 1;
        //angle += Time.deltaTime * direction * speed;

        //float x = Mathf.Cos(angle) * radiusOffset;
        //float y = Mathf.Sin(angle) * radiusOffset;

        //this.transform.position = new Vector3(mainPosition.x + x, mainPosition.y + y, 0);
        //this.transform.position += Vector3.Cross((main.transform.position - this.transform.position).normalized, new Vector3(0, 0, 1)).normalized/100;
    }
}
