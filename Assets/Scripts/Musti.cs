using UnityEngine;

public class Musti : MonoBehaviour
{
    public float move_Speed;

    public float startTime;
    public float waitTime;
    public Transform movePoints;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;


    void Start()
    {
        movePoints.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
    }

    // Update is called once per frame
    void Update()
    {
        EnemyShipMovement();
    }

    private void EnemyShipMovement()
    {
        transform.position = Vector2.MoveTowards(transform.position, movePoints.position, move_Speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, movePoints.position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                movePoints.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
                waitTime = startTime;
            }

            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }
}
