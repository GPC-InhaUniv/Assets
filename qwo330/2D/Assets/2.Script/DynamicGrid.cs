using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DynamicGrid : MonoBehaviour {
    public int cnt = 5;
    public int minColsInARow = 5;
    public int maxRow = 1;
    [Range(0, 50)]
    public int padding = 3;
    [Range(0, 50)]
    public int spacing = 6;

    private float originWidth, originHeight;
    private RectTransform parent;
    private GridLayoutGroup grid;

	// Use this for initialization
	void Start () {
        parent = gameObject.GetComponent<RectTransform>();
        grid = gameObject.GetComponent<GridLayoutGroup>();

        originWidth = parent.rect.width;
        originHeight = parent.rect.height;
    }

    private void Update()
    {
        SetDynamicGrid(cnt, minColsInARow, maxRow, padding, spacing);
    }

    // cnt : 컬럼 총 개수, minColsInARow : 한 Row에 최소 컬럼 개수, maxRow : 최대 Row 수 , padding : padding 비율, spacing : spacing 비율
    public void SetDynamicGrid(int cnt, int minColsInARow, int maxRow, int padding, int spacing)
    {
        int rows = Mathf.Clamp(Mathf.CeilToInt((float)cnt / minColsInARow), 1, maxRow + 1);
        int cols = Mathf.CeilToInt((float)cnt / rows);
        

        float paddingSize = Mathf.Min(padding / parent.rect.width, padding / parent.rect.height);
        float spacingSize = Mathf.Min(spacing / parent.rect.width, spacing / parent.rect.height) / 10;

        float spaceW = (2 + cols - 1) * padding;
        float spaceH = (2 + rows - 1) * padding;

        float maxWidth = originWidth - spaceW;
        float maxHeight = originHeight - spaceH;

        float width = Mathf.Min(parent.rect.width - spaceW, maxWidth);
        float height = Mathf.Min(parent.rect.height - spaceH, maxHeight);

        float cellSize = Mathf.Min(width, height);

        grid.cellSize = new Vector2(cellSize, cellSize);
        grid.spacing = new Vector2(spacing, 0.0f);
    }
}
