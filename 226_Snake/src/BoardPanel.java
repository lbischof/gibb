import java.awt.Color;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.Point;
import java.awt.RenderingHints;

import javax.swing.JPanel;

/*
 * The board grid. All the GameElements are stored here.
 */
@SuppressWarnings("serial")
public class BoardPanel extends JPanel {
	/**
	 * The number of columns on the board. 
	 */
	public static final int COL_COUNT = 25;
	
	/**
	 * The number of rows on the board.
	 */
	public static final int ROW_COUNT = 25;
	
	/**
	 * The size of each tile in pixels.
	 */
	public static final int TILE_SIZE = 20;
	
	
		
	/**
	 * The Game instance.
	 */
	private Game game;
	
	/**
	 * The array of tiles that make up this board.
	 */
	private GameElement[] tiles;
	
	/**
	 * Creates a new BoardPanel instance.
	 * @param game The Game instance.
	 */
	public BoardPanel(Game game) {
		this.game = game;
		this.tiles = new GameElement[ROW_COUNT * COL_COUNT];
		
		setPreferredSize(new Dimension(COL_COUNT * TILE_SIZE, ROW_COUNT * TILE_SIZE));
		setBackground(Color.DARK_GRAY);
	}
	
	/**
	 * Clears all of the tiles on the board and sets their values to null.
	 */
	public void clearBoard() {
		for(int i = 0; i < tiles.length; i++) {
			tiles[i] = null;
		}
	}
	
	/**
	 * Sets the tile at the desired coordinate.
	 * @param point The coordinate of the tile.
	 * @param element The GameElement that should be present on the tile.
	 */
	public void setTile(Point point, GameElement element) {
		setTile(point.x, point.y, element);
	}
	
	/**
	 * Sets the tile at the desired coordinate.
	 * @param x The x coordinate of the tile.
	 * @param y The y coordinate of the tile.
	 * @param element The GameElement that should be present on the tile.
	 */
	public void setTile(int x, int y, GameElement element) {
		tiles[y * ROW_COUNT + x] = element;
	}	
	
	/**
	 * Sets the tile at the desired position.
	 * @param index The index in the tiles list.
	 * @param element The GameElement that should be present on the tile.
	 */
	public void setTile(int index, GameElement element) {
		tiles[index] = element;
	}
	
	/**
	 * Gets the tile at the desired coordinate.
	 * @param x The x coordinate of the tile.
	 * @param y The y coordinate of the tile.
	 * @return 	The GameElement on the tile
	 */
	public GameElement getTile(int x, int y) {
		return tiles[y * ROW_COUNT + x];
	}
	
	/**
	 * Gets the tile at the desired position.
	 * @param index The index in the tiles list.
	 * @return 	The GameElement on the tile
	 */
	public GameElement getTile(int index) {
		return tiles[index];
	}
	
	@Override
	public void paintComponent(Graphics g) {
		super.paintComponent(g);
		
		/*
		 * Loop through each tile on the board and draw it if it
		 * is not null.
		 */
		for(int x = 0; x < COL_COUNT; x++) {
			for(int y = 0; y < ROW_COUNT; y++) {
				GameElement element = getTile(x, y);
				if(element != null) {
					element.draw(x * TILE_SIZE, y * TILE_SIZE, g);
				}
			}
		}
		
		/*
		 * Show a message on the screen based on the current game state.
		 */
		if(game.isGameOver() || game.isNewGame()) {
			Graphics2D g2 = (Graphics2D) g;
			g2.setRenderingHint(RenderingHints.KEY_ANTIALIASING,
				    RenderingHints.VALUE_ANTIALIAS_ON);
			g2.setColor(Color.BLACK);
				
			/*
			 * Get the center coordinates of the board.
			 */
			int centerX = getWidth() / 2;	
			int centerY = getHeight() / 2;					
			
			/*
			 * Allocate the messages for and set their values based on the game
			 * state.
			 */
			String largeMessage = null;
			String smallMessage = null;
			if(game.isNewGame()) {
				largeMessage = "Snake Game!";
				smallMessage = "Press Enter to Start";
			} else if(game.isGameOver()) {
				largeMessage = "Score: " + game.getScore();
				smallMessage = "Press Enter to Restart";
			} 
			
			/*
			 * Set the message font and draw the messages in the center of the board.
			 */
			g2.setFont(new Font("Tahoma", Font.BOLD, 25));
			g2.drawString(largeMessage, centerX - g2.getFontMetrics().stringWidth(largeMessage) / 2, centerY - 50);
			g2.drawString(smallMessage, centerX - g2.getFontMetrics().stringWidth(smallMessage) / 2, centerY + 50);
		}
	}	
	
}
