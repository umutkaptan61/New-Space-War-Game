using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    [SerializeField] private PlayerShipType playerShipType = null;
   // private PlayerShipMove playerShipMove;

    private void Awake()
    {
        //playerShipMove = GetComponent<PlayerShipMove>();
    }
    void Start()
    {
        //playerShipMove.shipType
        GetComponent<SpriteRenderer>().sprite = playerShipType.playerShipSprite;
        //GetComponent<PlayerShipMove>().defaultMoveSpeed = playerShipType.playerShipMovementSpeed;
        transform.name = playerShipType.playerShipName;
        transform.localScale = playerShipType.playerShipScale;
    }
    
   
}
