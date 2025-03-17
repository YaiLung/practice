using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Если нужно хранить глобальные данные, можно использовать ScriptableObject:
/// </summary>

public class Player1 : MonoBehaviour
{
    public GameData data;

    void Start()
    {
        Debug.Log("Max Health: " + data.maxHealth);
    }
}
