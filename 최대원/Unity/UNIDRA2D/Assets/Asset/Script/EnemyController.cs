using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform areaTopLeft;
    public Transform areaBottomRight;
    public GameObject firePrefeb;
    public float minTime = 1f;
    public float maxTime = 2f;
    public float AttackDelay = 2.0f;

    IEnumerator Attack1()
    {
        Instantiate(firePrefeb, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(AttackDelay);
        StartCoroutine(Attack1());
    }

    IEnumerator Move()
    {
        //이동===========================
        Vector3 from_position = transform.position;
        Vector3 to_position = new Vector3(
            Random.Range(areaTopLeft.position.x, areaBottomRight.position.x),
            Random.Range(areaBottomRight.position.y, areaTopLeft.position.y),
            transform.position.z
            );
        float start_time = Time.time;
        float move_time = Random.Range(minTime, maxTime);

        while (true)
        {
            float t = (Time.time - start_time) / move_time;
            transform.position = Vector3.Lerp(from_position, to_position, t);
            if (t >= 1f)
            {
                break;
            }
            yield return null;
        }

        StartCoroutine(Move());
    }

    private void Start()
    {
        StartCoroutine(Attack1());
        StartCoroutine(Move());
    }
}
