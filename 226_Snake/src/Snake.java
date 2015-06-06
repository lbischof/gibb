import java.awt.Color;
import java.awt.Graphics;
import java.awt.Point;
import java.util.LinkedList;


public class Snake extends GameElement {
	private Direction direction;
	private LinkedList<Point> snake;
		
	/**
	 * The minimum length of the snake. This allows the snake to grow
	 * right when the game starts, so that we're not just a head moving
	 * around on the board.
	 */
	private static final int MIN_SNAKE_LENGTH = 5;
	
	private int fruitsEaten;


	public Snake(Game game) {
		super(game);	
		this.snake = new LinkedList<Point>();
	}
		
	private boolean isOutOfBounds(Point head) {
		
		/*
		 * Check if the head is a valid board position
		 */
		if (!board.inBounds(head.x, head.y)) {
			return true;
		}
		
		/*
		 * Also check horizontal position because the board would 
		 * just wrap the snake to the other side
		 */
		if(head.x < 0 || head.x >= BoardPanel.ROW_COUNT) {
			return true;
		}
		
		return false;
	}
	
	private void removeTail() {
		Point tail = snake.removeLast();
		board.setTile(tail, null);
	}
	
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
	
	public int getSize() {
		return snake.size();
	}
	
	public void setDirection(Direction direction){	
		if (this.direction.opposite() != direction)
			this.direction = direction;
	}
	
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
	
	@Override
	public void draw(int x, int y, Graphics g) {
		int tileSize = board.getTileSize();
		g.setColor(Color.GREEN);
		g.fillRect(x , y, tileSize, tileSize);	
	}

	@Override
	public void collide() {
		game.gameOver();
	}
}
		