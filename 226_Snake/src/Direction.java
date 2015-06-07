/**
 * The enum is used to determine which way the Snake is moving.
 * The "opposite" code is written by Sindri Joelsson:
 * https://stackoverflow.com/questions/1575146/how-can-i-associate-an-enum-with-its-opposite-value-as-in-cardinal-directions
 *
 */
public enum Direction {

	/**
	 * Moving North (Up).
	 */
	North(1),
	
	/**	
	 * Moving South (Down).
	 */
	South(0),
	
	/**
	 * Moving East (Right).
	 */
	East(3),
	
	/**
	 * Moving West (Left).
	 */
	West(2);
	
	private final int opposite;
	
	Direction(int opposite) {
		this.opposite = opposite;
	}
	
	Direction opposite() {
		return Direction.values()[this.opposite];
	}
	
}
