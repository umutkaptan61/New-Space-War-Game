using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewShip", menuName = "NewEnemyShip", order = 0)]

public class EnemyShipType : ScriptableObject
{
    public Sprite enemyShipSprite;
    public Vector3 enemyShipScale;
    public float enemyShipMovementSpeed;   
    public Quaternion enemyShipRotation;
}
