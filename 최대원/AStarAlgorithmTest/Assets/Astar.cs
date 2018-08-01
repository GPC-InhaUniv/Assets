using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astar : MonoBehaviour
{
    NodeGanarate nodeGanarate;
    int ganarateXsize;
    int ganarateZsize;

    Node[,] nodeArray;
    List<Node> openSet;
    List<Node> closedSet;

    [SerializeField]
    int currentXPos;
    [SerializeField]
    int currentZPos;

    [SerializeField]
    int startXPos;
    [SerializeField]
    int startZPos;

    [SerializeField]
    int endXPos;
    [SerializeField]
    int endZPos;

    int[] coordX = { -1, 1, 0, 0 };
    int[] coordZ = { 0, 0, -1, 1 };

    private void Start()
    {
        StartCoroutine(AstarSetting());
    }

    public void startAlgorithm()
    {
        StartCoroutine(StartAstarAlgorithm());
    }

    IEnumerator AstarSetting()
    {   
        nodeGanarate = GetComponent<NodeGanarate>();
        ganarateXsize = nodeGanarate.ganarateXsize;
        ganarateZsize = nodeGanarate.ganarateZsize;

        yield return  nodeGanarate.CreateNode();
        nodeArray = nodeGanarate.nodeArray;

        openSet = new List<Node>();
        closedSet = new List<Node>();

        startXPos = 0;
        startZPos = 0;
        currentXPos = startXPos;
        currentZPos = startZPos;
        endXPos = 4;
        endZPos = 4;
    }

    IEnumerator StartAstarAlgorithm()
    {
        //시작, 끝 노드에 색 입히기
        nodeArray[startXPos, startZPos].meshRenderer.material = nodeGanarate.startColor;
        nodeArray[endXPos, endZPos].meshRenderer.material = nodeGanarate.endColor;

        //첫 노드를 클로즈드셋에 추가
        EnqueueClosedSet(nodeArray[startXPos, startZPos]);
        //인근노드 탐색
        SearchAdjacentNode(startXPos, startZPos);

        do
        {
            //정렬된 오픈셋 중 첫번째 인접노드로 이동
            //DequeueOpenSet().Parent = nodeArray[currentXPos, currentZPos];
            Debug.Log("DequeueOpenSet() : " + DequeueOpenSet().NodePosX + ", " + DequeueOpenSet().NodePosZ);
            Debug.Log("DequeueOpenSet().Parent : " + DequeueOpenSet().Parent.NodePosX + ", " + DequeueOpenSet().Parent.NodePosZ);
            Debug.Log("==== Move Node ====");
            openSet.Remove(nodeArray[currentXPos, currentZPos]);
            currentXPos = DequeueOpenSet().NodePosX;
            currentZPos = DequeueOpenSet().NodePosZ;

            //경로에 색 입히기
            if(nodeArray[currentXPos, currentZPos].Parent != nodeArray[startXPos, startZPos])
            {
                if(nodeArray[currentXPos, currentZPos].Parent != null)
                nodeArray[currentXPos, currentZPos].Parent.meshRenderer.material = nodeGanarate.pathColor;
            }

            yield return new WaitForSeconds(1.0f);

            // 이전 노드를 클로즈드셋에 추가한다.
            EnqueueClosedSet(nodeArray[currentXPos, currentZPos].Parent);

            //이동한 노드가 도착지이면 종료
            if (currentXPos == endXPos && currentZPos == endZPos)
            {
                nodeArray[endXPos, endZPos].meshRenderer.material = nodeGanarate.endColor;
                traceParentNode(endXPos, endZPos);
                yield break;
            }

            //오픈셋을 비우고 인접노드를 새로 구한다.
            //openSet.Clear();
            SearchAdjacentNode(currentXPos, currentZPos);
        }
        while (DequeueOpenSet() != null);//다음 노드가 없다 = 길을 못찾음

        yield break;

    }

    void EnqueueOpenSet(Node node)
    {

        //해당 노드가 벽이면 클로즈드셋에 추가
        if (node.IsWall)
        {
            EnqueueClosedSet(node);
            return;
        }

        //해당 노드가 이미 클로즈드셋에 있으면 리턴
        if (closedSet.Contains(node))
        {
            return;
        }

        //오픈셋에 노드를 추가하고 바로 정렬
        openSet.Add(node);
        node.Parent = nodeArray[currentXPos, currentZPos];
        node.PathCost = CalculatePathCost(node);
        node.HeuristicCost = CalculateHeuristicCost(node);
        if(node.PathCost < nodeArray[currentXPos, currentZPos].PathCost)
        {
            node.beforePartCost = nodeArray[currentXPos, currentZPos].PathCost;
        }
        node.TotalCost = node.PathCost + node.HeuristicCost + node.beforePartCost;

        //노드에 색 입히기
        node.meshRenderer.material = nodeGanarate.opensetColor;

        if (openSet.Count > 1)
        {
            openSet.Sort(delegate (Node a, Node b)
            {
                if (a.TotalCost > b.TotalCost) return 1;
                else if (a.TotalCost < b.TotalCost) return -1;
                return 0;
            });

            foreach (Node tempNode in openSet)
            {
                Debug.Log("TotalCost in openset : " + tempNode.TotalCost);
            }
        }
    }

    Node DequeueOpenSet()
    {
        if (openSet.Count > 0)
        {
            return openSet[0];
        }
        else return null;
    }
    
    int OpenSetSort(Node a, Node b)
    {
        if (a.TotalCost > b.TotalCost)
        {
            return 1;
        }
        else if (a.TotalCost < b.TotalCost)
        {
            return -1;
        }
        return 0;
    }

    void EnqueueClosedSet(Node node)
    {
        closedSet.Add(node);
    }

    int CalculateHeuristicCost(Node node)
    {
        return Mathf.Abs(node.NodePosX - nodeArray[endXPos, endZPos].NodePosX)
            + Mathf.Abs(node.NodePosZ - nodeArray[endXPos, endZPos].NodePosZ);
    }

    int CalculatePathCost(Node node)
    {
        return Mathf.Abs(nodeArray[startXPos, startZPos].NodePosX - node.NodePosX)
            + Mathf.Abs(nodeArray[startXPos, startZPos].NodePosZ - node.NodePosZ);
    }

    void SearchAdjacentNode(int posX, int posZ)
    {
        for (int i = 0; i < coordX.Length; i++)
        {
            if (posX + coordX[i] >= 0 && posX + coordX[i] < ganarateXsize)
            {
                if (posZ + coordZ[i] >= 0 && posZ + coordZ[i] < ganarateZsize)
                {
                    EnqueueOpenSet(nodeArray[posX + coordX[i], posZ + coordZ[i]]);
                }
            }
        }
    }

    void traceParentNode(int currentXPos, int currentZPos)
    {
        if (nodeArray[currentXPos, currentZPos].Parent != nodeArray[startXPos, startZPos])
        {
            nodeArray[currentXPos, currentZPos].Parent.meshRenderer.material = nodeGanarate.currentColor;
            traceParentNode(nodeArray[currentXPos, currentZPos].Parent.NodePosX, nodeArray[currentXPos, currentZPos].Parent.NodePosZ);
        }
    }
}
