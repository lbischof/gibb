import java.awt.Frame;
import java.awt.Graphics;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.awt.event.MouseMotionListener;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

import javax.swing.JPanel;
import javax.swing.KeyStroke;

@SuppressWarnings("serial")
public class Papier extends JPanel implements MouseListener, MouseMotionListener, KeyListener {
	private int x,y;
	private Zeichnung zeichnung = new Zeichnung();
	Figur f = null;
	private char mode = 'r';
	
	public Papier() {
		addMouseListener(this);
		addMouseMotionListener(this);
		addKeyListener(this);
		this.setFocusable(true);
	}

	public void paintComponent(final Graphics g){
		super.paintComponent(g);
		if (zeichnung != null) zeichnung.draw(g);
	}
	
	public void setZeichnung(final Zeichnung zeichnung){
		this.zeichnung = zeichnung;
	}
	
	public void keyPressed(KeyEvent e) {
		Pattern pattern = Pattern.compile("^[rlk]$");
		Matcher matcher = pattern.matcher(e.getKeyChar() + "");
		if(matcher.matches()) {
		     mode = e.getKeyChar();
		}
	}

	public void mousePressed(MouseEvent e) {
		this.x = e.getX();
		this.y = e.getY();
	}
	
	public void mouseReleased(MouseEvent e) {
		this.f = drawFigur(e);
	}
	public void mouseDragged(MouseEvent e) {
		
	}
	private Figur drawFigur(MouseEvent e) {
		int width, height;
		if (e.getX() > this.x) {
			width = e.getX() - this.x;
		} else {
			width = this.x - e.getX();
			this.x -= width;
		}
		if (e.getY() > this.y) {
			height = e.getY() - this.y;
		} else {
			height = this.y - e.getY();
			this.y -= height;
		}
		switch (mode) {
		case 'r':
			f = new Rechteck(x, y, width, height);
			break;
		case 'l': 
			f = new Linie(x,y,e.getX(), e.getY());
			break;
		case 'k':
			f = new Kreis(x, y, width, height);
			break;
		}
		zeichnung.addFigur(f);
		repaint();
		return f;
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
