using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSetCompare : IComparer<Node>
{
    public int Compare(Node x, Node y)
    {
        if (x.TotalCost < y.TotalCost)
        {
            return x.TotalCost;
        }
        else
            return y.TotalCost;
    }
}
