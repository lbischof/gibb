import java.awt.Graphics;
import java.awt.Point;


abstract class GameElement {
	BoardPanel board;
	Game game;
	public GameElement(Game game) {
		this.board = game.getBoard();
		this.game = game;
	}
	abstract void draw(int x, int y, Graphics g);
	abstract void collide();
}
