using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContainer : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float XminPosition;
    public float xMaxPosition;
    public float yPosition;

    public float TimeToCreateEnemy = 5;
    public float currentTimeToCreateEnemy;
    public GameManagerControl GameManager;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        currentTimeToCreateEnemy = currentTimeToCreateEnemy + Time.deltaTime;
        if(currentTimeToCreateEnemy >= TimeToCreateEnemy)
        {
            CreateEnemy();
            currentTimeToCreateEnemy = 0;

        }
    
    }

    void CreateEnemy()
    {
        float xPosition = Random.Range(XminPosition, xMaxPosition);
        Vector2 positionToCreate = new Vector2(xPosition, yPosition);
        GameObject enemy = Instantiate(enemyPrefab, positionToCreate, transform.rotation);
        enemy.GetComponent<VelocidadEnemigo>().SetGameManager(GameManager);
    }
}

