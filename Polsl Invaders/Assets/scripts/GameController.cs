using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject enemy;
    public GameObject boss;
    public static int points;           //punkty
    public Vector3 spawnValues;
    public int enemyCount;              //ilosc przeciwnikow
    public float spawnWait;             //co ile sie maja pojawiac
    public float spawnStart;            //kiedy ma sie pojawic pierwszy
    public float bossSpawnWait;
    public GUIText scoreText;

	void Start () {
        
        StartCoroutine(spawnWaves());
        points = 0;
        scoreUpdate();
		
	}

    IEnumerator spawnWaves() //ni mom pojecia czemu funkcja ma taki typ
    {
        yield return new WaitForSeconds(spawnStart);
        int i;
        for ( i = 0; i < enemyCount; i++)
        {
            Quaternion spawnRotation = new Quaternion(0, 0, -180f, 0);
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);

            Instantiate(enemy, spawnPosition, spawnRotation);
            yield return new WaitForSeconds(spawnWait);
        }
        yield return new WaitForSeconds(bossSpawnWait);
        Quaternion spawnRotation2 = new Quaternion(0, 0, -180f, 0);
        Instantiate(boss, new Vector3(0, spawnValues.y, spawnValues.z),  spawnRotation2);
    }

  /*  void OnGUI()
    {
        GUI.Label(new Rect(Vector2.zero, new Vector2(150f, 200f)), points.ToString());
    }*/

    void scoreUpdate()
    {
        scoreText.text = "Score: " + points; 
    }

   /* int randomize()
    {
        Random rnd = new Random.Range();
    
        return rnd;
    }*/

    public void addPoint(int point_value)
    {
        points+=point_value;
        scoreUpdate();
    }
}


