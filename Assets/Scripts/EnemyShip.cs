using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    [SerializeField] private EnemyShipType enemyShipType = null;

    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = enemyShipType.enemyShipSprite;
        
        GetComponent<EnemyShipMove>().move_Speed = enemyShipType.enemyShipMovementSpeed;      
        transform.localScale = enemyShipType.enemyShipScale;
        transform.rotation = enemyShipType.enemyShipRotation;
    }      
}
