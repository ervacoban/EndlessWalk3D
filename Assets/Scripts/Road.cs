using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    [SerializeField] private GameObject roadPrefab;
    [SerializeField] private Vector3 lastRoad;
    [SerializeField] private float offset = 0.7071068f;
    private int roadCount = 0;

    private void Awake()
    {
        for (int i = 0; i < 15; i++) // Before loading the scene, 15 random road will be generated
        {
            NewRoad();
        }
    }

    public void StartBuildingRoad()
    {
        InvokeRepeating("NewRoad", 1f, 0.2f);
    }

    public void NewRoad()
    {
        Vector3 spawnPosition = Vector3.zero;
        float chance = Random.Range(0, 100);
        if(chance < 50)
        {
            spawnPosition = new Vector3(lastRoad.x + offset, lastRoad.y, lastRoad.z + offset);
        }
        else
        {
            spawnPosition = new Vector3(lastRoad.x - offset, lastRoad.y, lastRoad.z + offset);
        }
        GameObject road = Instantiate(roadPrefab, spawnPosition, Quaternion.Euler(0, 45, 0));
        lastRoad = road.transform.position;
        roadCount++;
        if(roadCount % 4 == 0)
        {
            road.transform.GetChild(0).gameObject.SetActive(true); 
        }
    }
}
