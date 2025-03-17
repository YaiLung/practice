using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Если нужно хранить глобальные данные, можно использовать ScriptableObject:
/// </summary>


[CreateAssetMenu(fileName = "GameData", menuName = "ScriptableObjects/GameData")]
public class GameData : ScriptableObject
{
    public int maxHealth = 100;
}
