using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject enemy;
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
        for (int i = 0; i < enemyCount; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(enemy, spawnPosition, spawnRotation);
            yield return new WaitForSeconds(spawnWait);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
