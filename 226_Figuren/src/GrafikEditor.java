import java.awt.Graphics;

public class GrafikEditor {
	public static void main(String[] args) {
		Zeichenbrett brett = new Zeichenbrett();
		Zeichnung zeichnung = new Zeichnung();
		Kreis k = new Kreis(100,100,40,30);
		
		zeichnung.addFigur(k);
		brett.zeige(zeichnung);
		k.move(410,15);
		brett.zeige(zeichnung);
	}
}
