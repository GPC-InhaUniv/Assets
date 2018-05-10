using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{

    public Transform areaTopLeft;
    public Transform areaBottomRight;
    public GameObject firePrefab;
    public float minTime = 0.5f;
    public float maxTime = 1f;


    /*
    IEnumerator Move()
    {
        Vector3 from_position = transform.position;
        Vector3 to_position = new Vector3(Random.Range(areaTopLeft.position.x, areaBottomRight.position.x),
            Random.Range(areaBottomRight.position.y, areaTopLeft.position.y),
            transform.position.z);
        float start_time = Time.time;
        float move_time = Random.Range(minTime, maxTime);

        while (true)
        {
            float t = (Time.time - start_time) / move_time;
            transform.position = Vector3.Lerp(from_position, to_position, t);
            if (t >= 0.2f) break;
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
        GameObject breath =  Instantiate(firePrefab, transform.position, Quaternion.identity);
        breath.GetComponent<Rigidbody2D>().AddForce(new Vector2(100.0f, 0f));

     //   yield return new WaitForSeconds(DiffusingBreathTime);
     //   Instantiate(DiffusingFirePrefab, transform.position, Quaternion.identity);
    }
    */

    
    IEnumerator Attack()
    {
        if (Unidra2DGameManager.Managerinstance.NowGamestate == 0)
        {
            Vector3 fromPosition = transform.position;
            Vector3 toPosition = new Vector3(
                Random.Range(areaTopLeft.position.x, areaBottomRight.position.x),
                Random.Range(areaBottomRight.position.y, areaTopLeft.position.y),
                transform.position.z);
            float startTime = Time.time;
            float moveTime = Random.Range(minTime, maxTime);
            while (true)
            {
                float t = (Time.time - startTime) / moveTime;
                transform.position = Vector3.Lerp(fromPosition, toPosition, t);
                if (t >= 0.2f)
                    break;
                yield return null;
            }
            GameObject Fire1;
            Fire1= Instantiate(firePrefab, transform.position, Quaternion.identity);
            GameObject Fire2;
            //Rigidbody2D FireRb2D;
            Fire2 = Instantiate(firePrefab, transform.position, Quaternion.identity);
            //FireRb2D =Fire2.GetComponent<Rigidbody2D>();
            //FireRb2D.AddForce(new Vector2(100f,0));
            Fire2.GetComponent<Rigidbody2D>().AddForce(new Vector2(100.0f, 0f));

            StartCoroutine(Attack());
        }
    }
    

    public void Start()
    {
        StartCoroutine(Attack());

    }
    
}