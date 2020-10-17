using UnityEngine;
using System.Collections;

public abstract class MazeAlgorithm {
	protected MazeCell[,] mazeCells;
	protected int mazeRows, mazeColumns;

	protected MazeAlgorithm(MazeCell[,] mazeCells) : base() {
		this.mazeCells = mazeCells;
		mazeRows = mazeCells.GetLength(0);
		mazeColumns = mazeCells.GetLength(1);
	}

	public abstract void CreateMaze ();

	private void InitializeMaze()
	{

		mazeCells = new MazeCell[mazeRows, mazeColumns];

		for (int r = 0; r < mazeRows; r++)
		{
			for (int c = 0; c < mazeColumns; c++)
			{
				mazeCells[r, c] = new MazeCell();

				if (c != mazeColumns - 1)
				{
					if ((c < 0.40 * mazeColumns || c > 0.60 * mazeColumns) || (r < 0.40 * mazeRows || r > 0.60 * mazeRows))
					{
						mazeCells[r, c].eastWall = Instantiate(wall, new Vector3(r * size + 3, 0, (c * size) + (size / 2f) + 3), Quaternion.identity) as GameObject;
						mazeCells[r, c].eastWall.name = "East Wall " + r + "," + c;
					}
				}

				if (r != mazeRows - 1)
				{
					if ((c < 0.40 * mazeColumns || c > 0.60 * mazeColumns) || (r < 0.40 * mazeRows || r > 0.60 * mazeRows))
					{
						mazeCells[r, c].southWall = Instantiate(wall, new Vector3((r * size) + (size / 2f) + 3, 0, c * size + 3), Quaternion.identity) as GameObject;
						mazeCells[r, c].southWall.name = "South Wall " + r + "," + c;
						mazeCells[r, c].southWall.transform.Rotate(Vector3.up * 90f);
					}
				}
			}
		}

	}
}
