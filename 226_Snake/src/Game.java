import java.awt.BorderLayout;
import java.awt.Point;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.util.LinkedList;
import java.util.Random;
import java.util.concurrent.TimeUnit;

import javax.swing.JFrame;


@SuppressWarnings("serial")
public class Game extends JFrame {
	

	/**
	 * The number of milliseconds that should pass between each frame.
	 */
	private long FRAME_TIME = 100L;
	
	/**
	 * The BoardPanel instance.
	 */
	private BoardPanel board;
	
	private GameState gameState;
	
	private Snake snake;
	
	private Food food;
	
	/**
	 * Creates a new SnakeGame instance. Creates a new window,
	 * and sets up the controller input.
	 */
	private Game() {
		super("Snake");
		setLayout(new BorderLayout());
		setDefaultCloseOperation(EXIT_ON_CLOSE);
		setResizable(false);
				
		/*
		 * Initialize the board.
		 */
		this.board = new BoardPanel(this);
		this.food = new Food(this);

		add(board, BorderLayout.CENTER);
		
		/*
		 * Adds a new key listener to the frame to process input. 
		 */
		addKeyListener(new KeyAdapter() {
			
			@Override
			public void keyPressed(KeyEvent e) {
				switch(e.getKeyCode()) {

				/*
				 * Turn North
				 */
				case KeyEvent.VK_UP:
					snake.setDirection(Direction.North);
					break;

				/*
				 * Turn South
				 */		
				case KeyEvent.VK_DOWN:
					snake.setDirection(Direction.South);
					break;
				
				/*
				 * Turn West
				 */						
				case KeyEvent.VK_LEFT:
					snake.setDirection(Direction.West);
					break;
			
				/*
				 * Turn East
				 */		
				case KeyEvent.VK_RIGHT:
					snake.setDirection(Direction.East);
					break;

				/*
				 * Reset the game.
				 */
				case KeyEvent.VK_ENTER:
					resetGame();
					break;
				}
			}
			
		});
		/*
		 * Resize the window to the appropriate size, center it on the
		 * screen and display it.
		 */
		pack();
		setLocationRelativeTo(null);
		setVisible(true);
	}
	
	/**
	 * Starts the game running.
	 */
	private void start() {
		/*
		 * Initialize everything we're going to be using.
		 */
		this.snake = new Snake(this);
		this.gameState = GameState.NewGame;

		/*
		 * This is the game loop. It will update and render the game and will
		 * continue to run until the game window is closed.
		 */
		while(true) {
			if (gameState == GameState.Playing) {
				snake.move();
		
				//Repaint the board and side panel with the new content.
				board.repaint();
			
				try {
					Thread.sleep(FRAME_TIME);
				} catch (InterruptedException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
			}
		}
	}
	

	public void gameOver() {
		this.gameState = GameState.GameOver;
	}
	/**
	 * Resets the game's variables to their default states and starts a new game.
	 */
	private void resetGame() {
		
		/*
		 * Reset both the new game and game over flags.
		 */
		this.gameState = GameState.Playing;
		
			
		this.snake.reset();
		
		/*
		 * Spawn a new fruit.
		 */
		this.food.spawn();
	}
	
	/**
	 * Gets the flag that indicates whether or not we're playing a new game.
	 * @return The new game flag.
	 */
	public boolean isNewGame() {
		return gameState == GameState.NewGame;
	}
	
	/**
	 * Gets the flag that indicates whether or not the game is over.
	 * @return The game over flag.
	 */
	public boolean isGameOver() {
		return this.gameState == GameState.GameOver;
	}
	
	public BoardPanel getBoard() {
		return board;
	}
	public Snake getSnake() {
		return snake;
	}
	public static void main(String[] args) {
		Game game = new Game();
		game.start();
	}
	
	
}
