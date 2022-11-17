using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.SavedGame
{
	[Token(Token = "0x20002F0")]
	public interface ISavedGameMetadata
	{
		[Token(Token = "0x170002E8")]
		bool IsOpen
		{
			[Token(Token = "0x6001713")]
			get;
		}

		[Token(Token = "0x170002E9")]
		string Filename
		{
			[Token(Token = "0x6001714")]
			get;
		}

		[Token(Token = "0x170002EA")]
		string Description
		{
			[Token(Token = "0x6001715")]
			get;
		}

		[Token(Token = "0x170002EB")]
		string CoverImageURL
		{
			[Token(Token = "0x6001716")]
			get;
		}

		[Token(Token = "0x170002EC")]
		TimeSpan TotalTimePlayed
		{
			[Token(Token = "0x6001717")]
			get;
		}

		[Token(Token = "0x170002ED")]
		DateTime LastModifiedTimestamp
		{
			[Token(Token = "0x6001718")]
			get;
		}
	}
}
