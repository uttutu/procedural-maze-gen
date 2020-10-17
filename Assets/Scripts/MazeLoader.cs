using UnityEngine;
using System.Collections;

public class MazeLoader : MonoBehaviour {
	public int mazeRows, mazeColumns;
	public GameObject wall;
	// public GameObject player;
	// public GameObject player2; //player2
	public float size = 2f;

	private MazeCell[,] mazeCells;

	// Use this for initialization
	void Start () {
		InitializeMaze ();

		MazeAlgorithm ma = new HuntAndKillMazeAlgorithm (mazeCells);
		ma.CreateMaze ();

		//  GameObject Player = Random.Range(0,100)>Random.Range(0,100) ? Instantiate (player, new Vector3 (Random.Range(0,100)>Random.Range(0,100) ? -10 : 210, 3, Random.Range(-10,221) ), Quaternion.identity) as GameObject : Instantiate (player, new Vector3 (Random.Range(-10,221), 3, Random.Range(0,100)>Random.Range(0,100) ? -10 : 210 ), Quaternion.identity) as GameObject ;
		//  GameObject Player2 = Random.Range(0,100)>Random.Range(0,100) ? Instantiate (player2, new Vector3 (Random.Range(0,100)>Random.Range(0,100) ? -10 : 210, 3, Random.Range(-10,221) ), Quaternion.identity) as GameObject : Instantiate (player2, new Vector3 (Random.Range(-10,221), 3, Random.Range(0,100)>Random.Range(0,100) ? -10 : 210 ), Quaternion.identity) as GameObject ; //player2
	}
	
	// Update is called once per frame
	void Update () {
	}

	//add function here
}
