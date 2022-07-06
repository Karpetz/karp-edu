namespace Mazes
{
	public static class DiagonalMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
			if (width > height)
			{
				int steps = (width - 2) / (height - 2);
				while (true)
				{
					for (int i = 0; i < steps; i++) robot.MoveTo(Direction.Right);
					if (robot.Finished) break;
					robot.MoveTo(Direction.Down);
				}
			}
			else
			{
				int steps = (height - 2) / (width - 2);
				while (true)
				{
					for (int j = 0; j < steps; j++) robot.MoveTo(Direction.Down);
					if (robot.Finished) break;
					robot.MoveTo(Direction.Right);
				}
			}
		}
	}
}