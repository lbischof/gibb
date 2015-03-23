package main;
import java.awt.Point;


public abstract class FigurFactory {
	  protected Character keyChar;
	 
	  public abstract Figur create(Point first, Point second);
	  
	  public Character getKeyChar() {
	    return keyChar;
	  }
}
