using UnityEngine;
using System.Collections;

public class MazeLoader : MonoBehaviour {
	public int mazeRows, mazeColumns;
	public GameObject wall;
	public GameObject plane;
	public float size = 2f;

	private MazeCell[,] mazeCells;

	private GameObject floor;

	// Use this for initialization
	void Start () {
		InitializeMaze ();

		MazeAlgorithm ma = new HuntAndKillMazeAlgorithm (mazeCells);
		ma.CreateMaze ();
	}
	
	// Update is called once per frame
	void Update () {
	}

	private void InitializeMaze() {
		
		floor = Instantiate(plane, new Vector3(mazeRows - 1f,-1,mazeColumns - 1f), Quaternion.identity) as GameObject;
		floor.name = "Maze Floor";
		floor.AddComponent<Rigidbody>();
		floor.transform.localScale = new Vector3((float)mazeRows/5,1,(float)mazeColumns/5);

		mazeCells = new MazeCell[mazeRows,mazeColumns];

		for (int r = 0; r < mazeRows; r++) {
			for (int c = 0; c < mazeColumns; c++) {
				mazeCells [r, c] = new MazeCell ();

				if (c == 0) {
					mazeCells[r,c].westWall = Instantiate (wall, new Vector3 (r*size, 0, (c*size) - (size/2f)), Quaternion.identity) as GameObject;
					mazeCells [r, c].westWall.name = "West Wall " + r + "," + c;
					mazeCells[r,c].westWall.AddComponent<FixedJoint>();
					mazeCells[r,c].westWall.GetComponent<FixedJoint>().connectedBody = floor.GetComponent<Rigidbody>();
					
				}

				mazeCells [r, c].eastWall = Instantiate (wall, new Vector3 (r*size, 0, (c*size) + (size/2f)), Quaternion.identity) as GameObject;
				mazeCells [r, c].eastWall.name = "East Wall " + r + "," + c;
				mazeCells[r,c].eastWall.AddComponent<FixedJoint>();
				mazeCells[r,c].eastWall.GetComponent<FixedJoint>().connectedBody = floor.GetComponent<Rigidbody>();

				if (r == 0) {
					mazeCells [r, c].northWall = Instantiate (wall, new Vector3 ((r*size) - (size/2f), 0, c*size), Quaternion.identity) as GameObject;
					mazeCells [r, c].northWall.name = "North Wall " + r + "," + c;
					mazeCells [r, c].northWall.transform.Rotate (Vector3.up * 90f);
					mazeCells[r,c].northWall.AddComponent<FixedJoint>();
					mazeCells[r,c].northWall.GetComponent<FixedJoint>().connectedBody = floor.GetComponent<Rigidbody>();
				}

				mazeCells[r,c].southWall = Instantiate (wall, new Vector3 ((r*size) + (size/2f), 0, c*size), Quaternion.identity) as GameObject;
				mazeCells [r, c].southWall.name = "South Wall " + r + "," + c;
				mazeCells [r, c].southWall.transform.Rotate (Vector3.up * 90f);
				mazeCells[r,c].southWall.AddComponent<FixedJoint>();
				mazeCells[r,c].southWall.GetComponent<FixedJoint>().connectedBody = floor.GetComponent<Rigidbody>();
			}
		}
	}
}
