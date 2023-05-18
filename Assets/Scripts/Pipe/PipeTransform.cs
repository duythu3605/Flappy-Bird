using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeTransform : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;

    private float leftEdge;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x -1.0f;
    }

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if(transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }
}
