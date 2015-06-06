import java.awt.Color;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.Graphics;
import java.awt.Point;

import javax.swing.JPanel;


@SuppressWarnings("serial")
public class BoardPanel extends JPanel {
	/**
	 * The number of columns on the board. (Should be odd so we can start in
	 * the center).
	 */
	public static final int COL_COUNT = 25;
	
	/**
	 * The number of rows on the board. (Should be odd so we can start in
	 * the center).
	 */
	public static final int ROW_COUNT = 25;
	
	/**
	 * The size of each tile in pixels.
	 */
	public static final int TILE_SIZE = 20;
	
	
	/**
	 * The font to draw the text with.
	 */
	private static final Font FONT = new Font("Tahoma", Font.BOLD, 25);
		
	/**
	 * The SnakeGame instance.
	 */
	private Game game;
	
	/**
	 * The array of tiles that make up this board.
	 */
	private GameElement[] tiles;
	/**
	 * Creates a new BoardPanel instance.
	 * @param game The SnakeGame instance.
	 */
	public BoardPanel(Game game) {
		this.game = game;
		this.tiles = new GameElement[ROW_COUNT * COL_COUNT];
		
		setPreferredSize(new Dimension(COL_COUNT * TILE_SIZE, ROW_COUNT * TILE_SIZE));
		setBackground(Color.BLACK);
	}
	
	/**
	 * Clears all of the tiles on the board and sets their values to null.
	 */
	public void clearBoard() {
		for(int i = 0; i < tiles.length; i++) {
			tiles[i] = null;
		}
	}
	
	public boolean inBounds(int x, int y) {
		return tiles.length > y * ROW_COUNT + x && y * ROW_COUNT + x >= 0;
	}	
		
	/**
	 * Sets the tile at the desired coordinate.
	 * @param point The coordinate of the tile.
	 * @param type The type to set the tile to.
	 */
	public void setTile(Point point, GameElement element) {
		setTile(point.x, point.y, element);
	}
	
	/**
	 * Sets the tile at the desired coordinate.
	 * @param x The x coordinate of the tile.
	 * @param y The y coordinate of the tile.
	 * @param type The type to set the tile to.
	 */
	public void setTile(int x, int y, GameElement element) {
		tiles[y * ROW_COUNT + x] = element;
	}	
	
	/**
	 * Gets the tile at the desired coordinate.
	 * @param x The x coordinate of the tile.
	 * @param y The y coordinate of the tile.
	 * @return
	 */
	public GameElement getTile(int x, int y) {
		return tiles[y * ROW_COUNT + x];
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
		 * Draw the grid on the board. This makes it easier to see exactly
		 * where we in relation to the fruit.
		 * 
		 * The panel is one pixel too small to draw the bottom and right
		 * outlines, so we outline the board with a rectangle separately.
		 */
		g.setColor(Color.DARK_GRAY);
		g.drawRect(0, 0, getWidth() - 1, getHeight() - 1);
		for(int x = 0; x < COL_COUNT; x++) {
			for(int y = 0; y < ROW_COUNT; y++) {
				g.drawLine(x * TILE_SIZE, 0, x * TILE_SIZE, getHeight());
				g.drawLine(0, y * TILE_SIZE, getWidth(), y * TILE_SIZE);
			}
		}		
		
		/*
		 * Show a message on the screen based on the current game state.
		 */
		if(game.isGameOver() || game.isNewGame()) {
			g.setColor(Color.WHITE);
				
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
				largeMessage = "Score: ";
				smallMessage = "Press Enter to Restart";
			} 
			
			/*
			 * Set the message font and draw the messages in the center of the board.
			 */
			g.setFont(FONT);
			g.drawString(largeMessage, centerX - g.getFontMetrics().stringWidth(largeMessage) / 2, centerY - 50);
			g.drawString(smallMessage, centerX - g.getFontMetrics().stringWidth(smallMessage) / 2, centerY + 50);
		}
	}
	
	
	public int getTileSize() {
		return TILE_SIZE;
	}
}
