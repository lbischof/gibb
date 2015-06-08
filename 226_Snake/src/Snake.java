import java.awt.Color;
import java.awt.Graphics;
import java.awt.Point;
import java.util.LinkedList;

/*
 * This class draws, moves the snake and checks collisions. 
 */
public class Snake extends GameElement {
	private Direction direction;
	private LinkedList<Point> snake;
		
	/**
	 * The minimum length of the snake. This allows the snake to grow
	 * right when the game starts, so that we're not just a head moving
	 * around on the board.
	 */
	private static final int MIN_SNAKE_LENGTH = 5;
	
	public Snake(Game game) {
		super(game);	
		this.snake = new LinkedList<Point>();
	}
	
	/*
	 * Checks if the head is out of bounds.
	 * @param head The position that should be checked
	 * @return True if the position is out of bounds.
	 */
	private boolean isOutOfBounds(Point head) {
		if(head.x < 0 || head.x >= BoardPanel.COL_COUNT || head.y < 0 || head.y >= BoardPanel.ROW_COUNT) {
			return true;
		}
		return false;
	}
	
	/*
	 * Removes the last body tile of the snake.
	 * This function gets called every move except if Food was eaten.
	 */
	private void removeTail() {
		Point tail = snake.removeLast();
		board.setTile(tail, null);
	}
	
	/*
	 * Moves the snake one tile in a specific direction.
	 */
	public void move() {
		Point head = new Point(snake.peekFirst());

		/*
		 * Here we calculate the new point that the snake's head will be at
		 * after the update.
		 */		
		switch(direction) {
		case North:
			head.y--;
			break;
			
		case South:
			head.y++;	
			break;
			
		case West:
			head.x--;
			break;
			
		case East:
			head.x++;
			break;
		}
		
		/*
		 * Check if the new position would be out of bounds.
		 */
		if (isOutOfBounds(head)) {
			game.gameOver();
			return;
		}
		
		GameElement element = board.getTile(head.x, head.y);
		if (element != null) {
			element.collide();
		} else if (snake.size() >= MIN_SNAKE_LENGTH) {			
			removeTail();
		}
		
		snake.push(head);
		board.setTile(head, this);

	}
	
	/*
	 * Get the size of the snake.
	 * @return The size of the snake.
	 */
	public int getSize() {
		return snake.size();
	}
	
	/*
	 * Sets the direction of the snake.
	 * @param direction The direction that the snake should move.
	 */
	public void setDirection(Direction direction){
		/*
		 * Check if the new direction is allowed
		 */
		if (this.direction.opposite() != direction)
			this.direction = direction;
	}
	
	/* 
	 * Resets the Snake to the middle of the board.
	 */
	public void reset() {
		/*
		 * Create the head at the center of the board.
		 */
		Point head = new Point(BoardPanel.COL_COUNT / 2, BoardPanel.ROW_COUNT / 2);
		snake.clear();
		snake.push(head);
		
		board.clearBoard();	
		board.setTile(head, this);
		
		direction = Direction.North;
	}
	
	/*
	 * Draw one snake tile.
	 * @param x The horizontal position of the tile
	 * @param y The vertical position of the tile
	 * @param g The Graphics object
	 */
	@Override
	public void draw(int x, int y, Graphics g) {
		g.setColor(Color.BLACK);
		g.fillRect(x , y, board.TILE_SIZE, board.TILE_SIZE);	
	}
	
	/*
	 * Collide with the snake.
	 */
	@Override
	public void collide() {
		game.gameOver();
	}
}
		
