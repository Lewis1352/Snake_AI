using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    //Object of our food prefab
    public GameObject foodPrefab;

    //Number of food we allow at a single time
    public int maxFood = 1;

    //Amount of food existing
    private int currentFood = 0;

    //Objects of our borders
    public Transform borderTop;
    public Transform borderButtom;
    public Transform borderLeft;
    public Transform borderRight;

    // Start is called before the first frame update
    void Start()
    {
        do
        {
            Spawn();
        }
        while(currentFood < maxFood);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentFood < maxFood)
        {
            Spawn();
        }
    }

    //Spawns single food
    void Spawn()
    {
        //Adds food to our food counter
        currentFood++;

        //Generates a random x position within our borders
        int xPos = (int)Random.Range(borderLeft.position.x, borderRight.position.x);

        //Generates a random y position within our borders
        int yPos = (int)Random.Range(borderButtom.position.y, borderTop.position.y);

        //Create food at our random x,y position with default rotation
        Instantiate(foodPrefab, new Vector2(xPos, yPos), Quaternion.identity);
    }



}
