import java.awt.Color;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.RenderingHints;
import java.util.Random;

/*
 * This class represents the food that will be eaten by the snake.
 */
public class Food extends GameElement {
	/**
	 * The random number generator (used for spawning Food).
	 */
	private Random random;
	
	/**
	 * Creates a new Food instance.
	 * @param game The Game instance.
	 */
	public Food(Game game) {
		super(game);
		this.random = new Random();
	}
		
	@Override
	public void draw(int x, int y, Graphics g) {
		/*
		 * Cast the Graphics object to Graphics2D for antialiasing.
		 */
		Graphics2D g2 = (Graphics2D) g;
		g2.setRenderingHint(RenderingHints.KEY_ANTIALIASING, RenderingHints.VALUE_ANTIALIAS_ON);
		g2.setColor(Color.RED);
		g2.fillOval(x + 2, y + 2, board.TILE_SIZE - 4, board.TILE_SIZE - 4);
	}

	@Override
	public void collide() {
		spawn();
		game.increaseScore();
	}
	
	/**
	 * Spawns a new Food onto the board.
	 */
	public void spawn() {	
		GameElement element;
		int index;
		while(true) {
			/*
			 * Get a random index based on the number of free spaces left on the board.
			 */
			index = random.nextInt(BoardPanel.COL_COUNT * BoardPanel.ROW_COUNT - game.getSnake().getSize());
			element = board.getTile(index);
			/*
			 * Check if the tile is free or else try again.
			 */
			if (element == null) {
				board.setTile(index, this);
				return;
			} 
		}
	}
}
