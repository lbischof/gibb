import java.awt.Graphics;


public abstract class Figur {
	protected int x, y;
	public Figur(int x, int y) {
		this.x = x;
		this.y = y;
	}
	public void move(int dx, int dy) {
		x += dx;
		y += dy;
	}
	public void resize(int x, int y) {
		this.x = x;
		this.y = y;
	}
	public abstract void draw(Graphics g);
	public abstract double area();
}
