import java.awt.Graphics;

/*
 * Some sort of element that can be drawn and can collide with the snake.
 */
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
