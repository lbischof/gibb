import java.awt.Graphics;


public class Linie extends Figur {
	private int ex, ey;
	public Linie(int x, int y, int ex, int ey) {
		super(x, y);
		this.ex = ex;
		this.ey = ey;
	}
	@Override
	public void move(int dx, int dy) {
		super.move(dx, dy);
		this.ex += dx;
		this.ey += dy;
	}
	@Override
	public void draw(Graphics g) {
		g.drawLine(x, y, ex, ey);
	}
	@Override
	public double area() {
		return 0;
	}
	
	
}
