using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject player;

    public static PlayerManager Instance;

    void Awake()
    {
        Instance = this;
    }
}
