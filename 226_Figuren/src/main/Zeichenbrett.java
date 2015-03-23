package main;
import javax.swing.JFrame;


@SuppressWarnings("serial")
public class Zeichenbrett extends JFrame {
	private final Papier papier = new Papier();
	public Zeichenbrett() {
		super("Zeichenbrett für Figuren");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setSize(800, 600);
		setLocation(200, 200);
		setContentPane(papier);
		setVisible(true);
	}
	public void zeige(Zeichnung zeichnung) {
		papier.setZeichnung(zeichnung);
		repaint();
	}
}
