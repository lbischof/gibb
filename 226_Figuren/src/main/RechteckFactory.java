package main;
import java.awt.Point;



public class RechteckFactory extends FigurFactory {

	  public RechteckFactory() {
	    keyChar = 'r';
	  }
	  
	  @Override
	  public Figur create(Point first, Point second) {
	    int breite = Math.abs(second.x - first.x);
	    int hoehe = Math.abs(second.y - first.y);
	    return new Rechteck(
	        second.x > first.x ? first.x : second.x, 
	        second.y > first.y ? first.y : second.y,
	        breite, hoehe
	        );
	  }
}
