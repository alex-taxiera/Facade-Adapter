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

//Calls
public class MediaAdapter implements IMediaPlayer
{
	IAdvancedMediaPlayer advancedMusicPlayer;
	
	//Constructor determines which subclass is needed and assigns 
	//the correct type to the interface
	public MediaAdapter(String audioType)
	{
		if (audioType.equalsIgnoreCase("vlc"))
		{
			advancedMusicPlayer = new VlcPlayer();
		}
		else if (audioType.equalsIgnoreCase("mp4"))
		{
			advancedMusicPlayer = new Mp4Player();
		}
	}
	
	//Calls the appropriate functions that are needed
	@Override
	public void play(String audioType, String fileName)
	{
		if (audioType.equalsIgnoreCase("vlc"))
		{
			advancedMusicPlayer.playVlc(fileName);
		}
		else if (audioType.equalsIgnoreCase("mp4"))
		{
			advancedMusicPlayer.playMp4(fileName);
		}
	}
}
