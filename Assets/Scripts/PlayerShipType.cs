using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewShip", menuName = "NewPlayerShip", order = 0)]

public class PlayerShipType : ScriptableObject   
{
    //public int shipType;
    public Sprite playerShipSprite;
    public Vector3 playerShipScale;
    public float playerShipMovementSpeed;
    public string playerShipName;
}
