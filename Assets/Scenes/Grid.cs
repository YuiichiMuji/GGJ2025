using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Grid : MonoBehaviour
{
    [SerializeField] private int width, height;
    [SerializeField]private Tile tilePrefab;
    [SerializeField] private Transform _camera;


    private void Start()
    {
        GenerateGrid();
    }

    public void GenerateGrid()
    {
        for (int x = 0; x < width; x++)
            for (int y = 0; y < height; y++)
            {
                var spawnedTile = Instantiate(tilePrefab, new Vector3(x, y), Quaternion.identity);
                spawnedTile.name = $"Tile {x}{y}";

                var isOffset = ((x % 2 == 0 && y % 2 != 0) || ((y % 2 == 0 && x % 2 != 0)));
                spawnedTile.Init(isOffset);
            }


        _camera.transform.position = new Vector3((float)width / 2 - 0.5f, 1.5f,-10);



    }










    //private int[,] GridArray;

    //public Grid(int width, int height)
    //{
    //    this.width = width;
    //    this.height = height;

    //    GridArray = new int[width, height];//确定网格大小

    //    for (int x = 0; x < GridArray.GetLength(0); x++)//遍历网格
    //        for (int y = 0; y < GridArray.GetLength(1); y++)
    //        {
                
    //        }
    //}


}
