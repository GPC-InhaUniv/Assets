using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeGanarate : MonoBehaviour {

    const int interval = 10;
    const int startPosX = -20;
    const int startPosZ = 20;

    public int ganarateXsize = 5;
    public int ganarateZsize = 5;

    public Node[,] nodeArray;
    [SerializeField]
    Node nodePrefab;

    [SerializeField]
    public Material startColor;
    [SerializeField]
    public Material currentColor;
    [SerializeField]
    public Material endColor;
    [SerializeField]
    public Material cubeColor;
    [SerializeField]
    public Material wallColor;
    [SerializeField]
    public Material pathColor;
    [SerializeField]
    public Material opensetColor;


    //int wallXPos = 3;
    //int wallZPos = 3;

    Node clickedTarget;

    public IEnumerator CreateNode()
    {
        nodeArray = new Node[ganarateXsize, ganarateZsize];

        for (int j = 0; j < ganarateXsize; j++)
        {
            for (int i = 0; i < ganarateZsize; i++)
            {
                nodeArray[i, j] = Instantiate(nodePrefab, gameObject.transform);
                Vector3 nodePosition = new Vector3((i * interval) + startPosX, 0, (j * interval) - startPosZ);
                nodeArray[i, j].transform.position = nodePosition;
                nodeArray[i, j].NodePosX = i;
                nodeArray[i, j].NodePosZ = j;
            }
        }

        yield return nodeArray;
    }

    //장애물 설정용
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, 100f))
            {
                GameObject obj = hit.collider.gameObject;
                clickedTarget = obj.GetComponentInParent<Node>();
                clickedTarget.IsWall = true;
                clickedTarget.meshRenderer.material = wallColor;
            }
        }
    }
}
 