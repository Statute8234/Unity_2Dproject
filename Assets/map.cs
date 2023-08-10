using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map : MonoBehaviour
{
    public GameObject imagePrefab; // The prefab of the image you want to use for the grid.
    public int gridSizeX = 5; // Number of images in X direction.
    public int gridSizeY = 5; // Number of images in Y direction.
    public float spacingX = 1f; // Spacing between images in X direction.
    public float spacingY = 1f; // Spacing between images in Y direction.
    public Vector2Int originPosition; // The origin position where the map-making process will start.

    private void Start()
    {
        CreateGrid();
    }

    private void CreateGrid()
    {
        Vector2 startPos = transform.position;
        Vector2 spawnOffset = new Vector2(originPosition.x * spacingX, originPosition.y * spacingY);

        for (int y = 0; y < gridSizeY; y++)
        {
            for (int x = 0; x < gridSizeX; x++)
            {
                Vector2 spawnPosition = startPos + new Vector2(x * spacingX, y * spacingY) - spawnOffset;
                GameObject newImage = Instantiate(imagePrefab, spawnPosition, Quaternion.identity);
                newImage.transform.SetParent(transform);
            }
        }
    }
}
