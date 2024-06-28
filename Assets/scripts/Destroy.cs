using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject defaultEnemyPrefab;
    public GameObject slovEnemyPrefab;
    public GameObject fastEnemyPrefab;
    public GameObject player;
    public GameObject platformPrefab;
    public GameObject springPrefab;

    private GameObject myPlat;
    private GameObject myEnemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if(Random.Range(1, 6) > 1)
        {

            myPlat = (GameObject)Instantiate(platformPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (8 + Random.Range(0.5f, 1f))), Quaternion.identity);
        
        }else
        {
            myPlat = (GameObject)Instantiate(springPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (8 + Random.Range(0.5f, 1f))), Quaternion.identity);

        }

        if(Random.Range(1, 11) == 7){
            int enemyRand = Random.Range(1, 4);
            if(enemyRand == 1)
            {
                myEnemy = (GameObject)Instantiate(defaultEnemyPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (17 + Random.Range(0.5f, 1f))), Quaternion.identity);
            }
            else if(enemyRand == 2)
            {
                myEnemy = (GameObject)Instantiate(slovEnemyPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (17 + Random.Range(0.5f, 1f))), Quaternion.identity);
            }else if(enemyRand == 3)
            {
                myEnemy = (GameObject)Instantiate(fastEnemyPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (17 + Random.Range(0.5f, 1f))), Quaternion.identity);
            }
        }

        Destroy(collision.gameObject);
    }
}
