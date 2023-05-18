using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    public float animSpeed = 1.0f;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    public void Init()
    {

    }

    private void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(animSpeed * Time.deltaTime, 0);
    }
}
