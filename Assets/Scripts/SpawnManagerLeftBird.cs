using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerLeftBird : MonoBehaviour
{
    [SerializeField] private int poolCount = 2;
    [SerializeField] private bool autoExpand = true;
    [SerializeField] private CharacterControllerLeftFly prefabBird;

    private SpawnManagerPool<CharacterControllerLeftFly> pool;
    public int time = 3;
    public int intervalTime = 3;

    private void Awake()
    {
        this.pool = new SpawnManagerPool<CharacterControllerLeftFly>(this.prefabBird, this.poolCount, this.transform);
        this.pool.autoExpend = this.autoExpand;
    }

    private void Start()
    {
        InvokeRepeating("CreatePrefab", time, intervalTime);
    }

    private void CreatePrefab()
    {
        var spawnPosition = transform.position;
        var shit = this.pool.GetFreeElement();
        shit.transform.position = spawnPosition;
    }
}
