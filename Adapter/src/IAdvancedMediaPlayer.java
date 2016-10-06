/*
 * Author: Jordan Twombly
 * Class: CSI 340-01
 * Assignment:  Facade and Adapter Pattern
 * Date Assigned: 9/8
 * Due Date:  10/6
 * 
 * Description:   
 * 		Demonstrates the implementation of the Adapter Design Pattern through the use of a media player,
 * 		using the adapter to process unsupported file types.
 * 
 * Certification of Authenticity: 
 *		I certify that this is entirely my own work, except where I have given 
 *		fully-documented references to the work of others. I understand the 
 *		definition and consequences of plagiarism and acknowledge that the assessor 
 *		of this assignment may, for the purpose of assessing this assignment: 
 *			- Reproduce this assignment and provide a copy to another member of
 *				academic staff; and/or
 *			- Communicate a copy of this assignment to a plagiarism checking 
 *				service (which may then retain a copy of this assignment on its 
 *				database for the purpose of future plagiarism checking)
 */

//Advanced interface providing support for what the original did not.
public interface IAdvancedMediaPlayer
{
	public void playVlc(String fileName);
	public void playMp4(String fileName);
}
