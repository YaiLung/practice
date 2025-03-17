using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Пример объявления переменных: 
/// </summary>
public class peremen : MonoBehaviour
    
{
    
    int score = 10;
    float speed = 5.5f;
    string playerName = "Oleg";
    bool isAlive = true;

    /*    В Unity переменные можно использовать в компонентах(MonoBehaviour).

    Области видимости переменных
    public – переменная доступна извне и видна в Inspector.
    private – переменная доступна только внутри класса.
    [SerializeField] – переменная приватная, но видна в Inspector.
    static – принадлежит классу, а не объекту.
    const – неизменяемая переменная(только для значений, известных во время компиляции).*/
    


}
