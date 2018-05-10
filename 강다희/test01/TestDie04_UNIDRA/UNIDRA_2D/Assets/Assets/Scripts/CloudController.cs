using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    [SerializeField]
    private float speed = 3f;

    private int move = 1;

    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (transform.localPosition.x > 3.0f)
        {
            move = 1;
        }
        else if (transform.localPosition.x < -3.0f)
            move = -1;

        transform.Translate(Vector3.left * speed * Time.deltaTime * move);
    }
}