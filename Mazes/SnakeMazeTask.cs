namespace Mazes
{
	public static class SnakeMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
			int startx = robot.X;
			while (true)
            {
				GoRight(robot, width);
				GoDown(robot);
				GoLeft(robot, startx);
				if(robot.Finished) break;
				GoDown(robot);
			}
		}
		private static void GoRight(Robot robot, int width)
        {
			while (robot.X != width - 2) robot.MoveTo(Direction.Right);
		}

		private static void GoDown(Robot robot)
		{
			robot.MoveTo(Direction.Down);
			robot.MoveTo(Direction.Down);
		}

		private static void GoLeft(Robot robot, int startx)
		{
			while (robot.X != startx) robot.MoveTo(Direction.Left);
		}

	}
}