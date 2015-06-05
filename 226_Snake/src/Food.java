import java.awt.Color;
import java.awt.Graphics;
import java.util.Random;


public class Food extends GameElement {
	/**
	 * The random number generator (used for spawning fruits).
	 */
	private Random random;
	
	
	public Food(Game game) {
		super(game);
		this.random = new Random();
	}
	
	@Override
	void draw(int x, int y, Graphics g) {
		g.setColor(Color.RED);
		g.fillOval(x + 2, y + 2, board.getTileSize() - 4, board.getTileSize() - 4);
	}

	@Override
	void collide() {
		spawn();		
	}
	

	/**
	 * Spawns a new fruit onto the board.
	 */
	public	 void spawn() {

		/*
		 * Get a random index based on the number of free spaces left on the board.
		 */
		int index = random.nextInt(BoardPanel.COL_COUNT * BoardPanel.ROW_COUNT - game.getSnake().getSize());
			
		/*
		 * While we could just as easily choose a random index on the board
		 * and check it if it's free until we find an empty one, that method
		 * tends to hang if the snake becomes very large.
		 * 
		 * This method simply loops through until it finds the nth free index
		 * and selects uses that. This means that the game will be able to
		 * locate an index at a relatively constant rate regardless of the
		 * size of the snake.
		 */
		int freeFound = -1;
		for(int x = 0; x < BoardPanel.COL_COUNT; x++) {
			for(int y = 0; y < BoardPanel.ROW_COUNT; y++) {
				GameElement element = board.getTile(x, y);
				if(element == null) {
					if(++freeFound == index) {
						board.setTile(x, y, this);
						break;	
					}
				}
			}
		}
	}


}
