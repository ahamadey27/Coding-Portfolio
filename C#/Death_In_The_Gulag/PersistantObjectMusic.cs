using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistantObjectMusic : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
