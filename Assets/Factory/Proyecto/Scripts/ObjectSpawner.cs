using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] private Factory _factory;

    public void SpawnObjectBush()
    {
        _factory.Create("Bush");
    }

    public void SpawnObjectTree()
    {
        _factory.Create("Tree");
    }

    public void SpawnObjectRock()
    {
        _factory.Create("Rock");
    }

}
