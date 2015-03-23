package main;

import java.awt.Point;


public class OvalFactory extends FigurFactory {

	  public OvalFactory() {
	    keyChar = 'k';
	  }
	  
	  @Override
	  public Figur create(Point first, Point second) {
		
		int height = second.y > first.y ? first.y - second.y : second.y - first.y;
		int width = second.x > first.x ? first.x - second.x : second.x - first.x;

	    return new Oval(first.x, first.y, width, height);
	  }
}
