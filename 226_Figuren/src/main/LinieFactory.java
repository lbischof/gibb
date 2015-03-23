package main;
import java.awt.Point;



public class LinieFactory extends FigurFactory {

	   public LinieFactory() {
	     keyChar = 'l';
	   }
	   
	   @Override
	   public Figur create(Point start, Point end) {
	     return new Linie(start.x, start.y, end.x, end.y);
	   }
}
