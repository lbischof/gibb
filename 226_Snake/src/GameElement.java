import java.awt.Graphics;

abstract class GameElement {
	BoardPanel board;
	Game game;
	public GameElement(Game game) {
		this.board = game.getBoard();
		this.game = game;
	}
	public abstract void draw(int x, int y, Graphics g);
	public abstract void collide();
}
