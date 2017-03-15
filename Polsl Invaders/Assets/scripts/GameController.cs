using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject enemy;
    public GameObject boss;
    public Vector3 spawnValues;
    public int enemyCount;              //ilosc przeciwnikow
    public float spawnWait;             //co ile sie maja pojawiac
    public float spawnStart;            //kiedy ma sie pojawic pierwszy
	void Start () {

        StartCoroutine(spawnWaves());
		
	}

    IEnumerator spawnWaves() //ni mom pojecia czemu funkcja ma taki typ
    {
        yield return new WaitForSeconds(spawnStart);
        int i;
        Quaternion spawnRotation = Quaternion.identity;
        for ( i = 0; i < enemyCount; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
            Instantiate(enemy, spawnPosition, spawnRotation);
            yield return new WaitForSeconds(spawnWait);
        }
        
            Instantiate(boss, new Vector3(0, spawnValues.y, spawnValues.z),  spawnRotation);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
