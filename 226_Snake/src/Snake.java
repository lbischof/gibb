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
	private static final int MIN_SNAKE_LENGTH = 10;
	
	private int fruitsEaten;


	public Snake(Game game) {
		super(game);	
		this.snake = new LinkedList<Point>();
	}
		
	private void detectCollision(Point head) {
		GameElement element = board.getTile(head.x, head.y);

		if(head.x < 0 || head.x >= BoardPanel.COL_COUNT || head.y < 0 || head.y >= BoardPanel.ROW_COUNT) {
			//isGameOver = true;
		}
		
		if (element != null) {
			element.collide();
		} else {
			removeTail();
		}
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
		
		detectCollision(head);

		snake.push(head);
		board.setTile(head, this);
	}
	public int getSize() {
		return snake.size();
	}
	public void setDirection(Direction direction){
		this.direction = direction;
	}

	public void reset() {
		/*
		 * Create the head at the center of the board.
		 */
		Point head = new Point(BoardPanel.COL_COUNT / 2, BoardPanel.ROW_COUNT / 2);
		snake.clear();
		snake.add(head);
		
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
		
	}
}
		