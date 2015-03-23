package main;
import java.awt.Graphics;


public class Oval extends Figur {
	private int width, height;
	public Oval(int x, int y, int width, int height) {
		super(x, y);
		this.width = width;
		this.height = height;
	}
	
	@Override
	public void draw(Graphics g) {
		// TODO Auto-generated method stub
		g.drawOval(x, y, width, height);
	}

	@Override
	public double area() {
		return 0;
	}

	public void resize(int x, int y, int width, int height) {
		super.resize(x, y);
		this.width = width;
		this.height = height;
	}
	
}
