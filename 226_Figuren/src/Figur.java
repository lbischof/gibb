import java.awt.Graphics;

/**
 * A base class for different types of figures
 */
public abstract class Figur {
	/**
	 * The horizontal position of the figure
	 */
	protected int x;	
	/**
	 * The vertical position of the figure
	 */
	protected int y;
	
	 /**
	  * Creates a new figure at a specified point
	  * 
	  * @param x   The X position of the figure
	  * @param y   The Y position of the figure
	  * 
	  */
	public Figur(int x, int y) {
		this.x = x;		
		this.y = y;
	}
	
	/**
	 * Moves the figure by a specified distance
	 *
	 * @param  dx  The delta that the figure should be moved horizontally
	 * @param  dy  The delta that the figure should be moved vertically
	 */
	public void move(int dx, int dy) {
		x += dx;
		y += dy;
	}
	
	/**
	 * Draws the figure
	 *
	 * @param  g   A Graphics object
	 */
	public abstract void draw(Graphics g);
	
	/**
	 * Calculate the area of the figure
	 *
     * @return   The area of the figure
	 */
	public abstract double area();
}