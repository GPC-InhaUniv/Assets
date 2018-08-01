using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Node Parent;
    public int TotalCost;
    public int PathCost;
    public int HeuristicCost;
    public int beforePartCost;
    public bool IsWall;
    public int NodePosX;
    public int NodePosZ;

    TextMesh textMesh;
    [SerializeField]
    public MeshRenderer meshRenderer;

    void Start ()
    {
        textMesh = GetComponent<TextMesh>();
    }

    private void Update()
    {
        textMesh.text = "("+NodePosX+", "+ NodePosZ+")\n" + "f(x) = " + TotalCost + "\n g(x) = " + PathCost + "\n h(x) = " + HeuristicCost + "\n p.g(x) = " + beforePartCost;
    }
}
