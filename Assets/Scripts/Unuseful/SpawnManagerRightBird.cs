using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerRightBird : MonoBehaviour
{
    [SerializeField] private int poolCount = 4;
    [SerializeField] private bool autoExpand = true;
    [SerializeField] private CharacterControllerBird prefabBird;

    private SpawnManagerPool<CharacterControllerBird> pool;
    public int time = 2;
    public int intervalTime = 2;

    private void Awake()
    {
        this.pool = new SpawnManagerPool<CharacterControllerBird>(this.prefabBird, this.poolCount, this.transform);
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
