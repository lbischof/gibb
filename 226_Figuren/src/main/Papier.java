package main;
import java.awt.Frame;
import java.awt.Graphics;
import java.awt.Point;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.awt.event.MouseMotionListener;
import java.util.Map;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

import javax.swing.JPanel;
import javax.swing.KeyStroke;

@SuppressWarnings("serial")
public class Papier extends JPanel implements MouseListener, MouseMotionListener, KeyListener {

	private Point p;
	private FigurFactory activeFactory;
	private Map<Character, FigurFactory> factories;
	
	private Zeichnung zeichnung = new Zeichnung();
	
	public Papier() {
		addMouseListener(this);
		addMouseMotionListener(this);
		addKeyListener(this);
		this.setFocusable(true);
		factories = FigurFactoryLoader.loadFigureFactories();
	}
	
	public void paintComponent(final Graphics g){
		super.paintComponent(g);
		if (zeichnung != null) zeichnung.draw(g);
	}
	
	public void setZeichnung(final Zeichnung zeichnung){
		this.zeichnung = zeichnung;
	}
	
	public void keyPressed(KeyEvent e) {
		activeFactory = factories.get(e.getKeyChar());  
	}

	public void mousePressed(MouseEvent e) {
		p = new Point(e.getX(), e.getY());
	}
	
	public void mouseReleased(MouseEvent e) {
		Figur f = activeFactory.create(p, new Point(e.getX(), e.getY()));
		zeichnung.addFigur(f);
	    repaint();
	}
	
	public void mouseDragged(MouseEvent e) {
		
	}
	
	
	public void mouseClicked(MouseEvent arg0) {}
	public void keyReleased(KeyEvent e) {}
	public void keyTyped(KeyEvent e) {}
	public void mouseEntered(MouseEvent arg0) {}
	public void mouseExited(MouseEvent arg0) {}

	@Override
	public void mouseMoved(MouseEvent e) {
		// TODO Auto-generated method stub
		
	}
}
