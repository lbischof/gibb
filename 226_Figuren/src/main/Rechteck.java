package main;
import java.awt.Graphics;


public class Rechteck extends Figur {
	private int width, height;
	public Rechteck(int x, int y, int width, int height) {
		super(x, y);
		this.width = width;
		this.height = height;
	}
	
	@Override
	public void draw(Graphics g) {
		g.drawRect(x, y, width, height);
	}

	@Override
	public double area() {
		return width * height;
	}
	
}
