using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public Transform areaTopLeft;
    public Transform areaBottomRight;
    public GameObject firePrefab, DiffusingFirePrefab;

    public float minTime = 1f;
    public float maxTime = 2f;
    public float BreathTime = 0.3f;
    public float DiffusingBreathTime = 5.0f;

    IEnumerator Move()
    {
        Vector3 from_position = transform.position;
        Vector3 to_position = new Vector3(Random.Range(areaTopLeft.position.x, areaBottomRight.position.x),
            Random.Range(areaBottomRight.position.y, areaTopLeft.position.y),
            transform.position.z);
        float start_time = Time.time;
        float move_time = Random.Range(minTime, maxTime);

        while(true)
        {
            float t = (Time.time - start_time) / move_time;
            transform.position = Vector3.Lerp(from_position, to_position, t);
            if (t >= 1f) break;
            yield return null;
        }

        // 도착 후 공격
        StartCoroutine(Move());
        StartCoroutine(Attack());
    }

    IEnumerator Attack()
    {
        yield return null;
        Instantiate(firePrefab, transform.position, Quaternion.identity);
        //GameObject breath =  Instantiate(firePrefab, transform.position, Quaternion.identity);
        //breath.GetComponent<Rigidbody2D>().AddForce(new Vector2(100.0f, 0));

        yield return new WaitForSeconds(DiffusingBreathTime);
        Instantiate(DiffusingFirePrefab, transform.position, Quaternion.identity);
    }

    // Use this for initialization
    void Start () {
        StartCoroutine(Move());
    }

    public void GameOver()
    {
        StopAllCoroutines();
    }
}
