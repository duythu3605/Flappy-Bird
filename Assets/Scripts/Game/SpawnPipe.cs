using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipe : MonoBehaviour
{
    public GameObject pipe;

    public Transform SpawnChildren;

    [SerializeField]
    private float spawnRate = 1.0f;

    [SerializeField]
    private float minHeigth = -1.0f;

    [SerializeField]
    private float maxHeight = 1.0f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    public void Spawn()
    {
        GameObject pipes = Instantiate(pipe, transform.position, Quaternion.identity, SpawnChildren);
        pipes.transform.position += Vector3.up * Random.Range(minHeigth, maxHeight);
    }

}
