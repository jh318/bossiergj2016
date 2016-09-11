using UnityEngine;
using System.Collections;

public class FoodSpawner : MonoBehaviour {
	
	public float spawnInterval = 1;
    public int maxSpawn = 10;
    public GameObject objectPrefab;

    public GameObject borderRight; //get arena borders
    public GameObject borderLeft;
    public GameObject borderTop;
    public GameObject borderBottom;

    private static bool inArena = false;
    private static int xSpawn = 0;
    private static int ySpawn = 0;

	void OnEnable(){
       StartCoroutine("SpawnCoroutine");
	}

    void OnDisable(){
        StopCoroutine("SpawnCoroutine");
    }
    
    IEnumerator SpawnCoroutine()
    {
        while (enabled){
            int activeCount = FoodObjectPooling.objectPool.FindAll(EnemyObjectPooling.IsActiveObject).Count;
            if (activeCount < maxSpawn){
                Spawn();
            }                
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void Spawn () {
        GameObject foodSpawned = FoodObjectPooling.Spawn(objectPrefab);
        xSpawn = Random.Range (-21, 21); //randomly generate x position between 2 numbers
        ySpawn = Random.Range (-21, 21); //randomly generate y position between 2 numbers
        inArena = false;//obj coord is not in arena

        if ((borderTop.transform.position.y > ySpawn && borderBottom.transform.position.y < ySpawn) && (borderLeft.transform.position.x < xSpawn && borderRight.transform.position.x > xSpawn)){
            //check if the generated coord is inside the arena
            inArena = true; //obj coord is not in area

            foodSpawned.transform.position = new Vector3 (xSpawn, ySpawn);
        }
    }

    public void Reset () {
        foreach (GameObject g in FoodObjectPooling.objectPool) {
            g.SetActive(false);
        }
        gameObject.SetActive(true);
    }

    public void DisableAll(){
        foreach (GameObject g in FoodObjectPooling.objectPool) {
            g.SetActive(false);
        }
    }
}