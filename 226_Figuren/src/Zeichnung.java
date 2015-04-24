import java.awt.Graphics;
import java.util.ArrayList;
import java.util.List;


public class Zeichnung {
	private List<Figur> figuren = new ArrayList<Figur>();
	
	public Zeichnung(List<Figur> figuren) {
		this.figuren = figuren; 
	}
	
	public Zeichnung() {}
	
	public void draw(Graphics g){
		for (Figur figur : figuren) {
			figur.draw(g);
		}
	}
	public boolean contains(Figur f) {
		return figuren.contains(f);
	}
	public void addFigur(Figur f) {
		figuren.add(f);
	}
	
}
