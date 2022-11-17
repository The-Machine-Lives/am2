using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Events
{
	[Token(Token = "0x2000306")]
	public interface IEvent
	{
		[Token(Token = "0x1700031D")]
		string Id
		{
			[Token(Token = "0x60017BF")]
			get;
		}

		[Token(Token = "0x1700031E")]
		string Name
		{
			[Token(Token = "0x60017C0")]
			get;
		}

		[Token(Token = "0x1700031F")]
		string Description
		{
			[Token(Token = "0x60017C1")]
			get;
		}

		[Token(Token = "0x17000320")]
		string ImageUrl
		{
			[Token(Token = "0x60017C2")]
			get;
		}

		[Token(Token = "0x17000321")]
		ulong CurrentCount
		{
			[Token(Token = "0x60017C3")]
			get;
		}

		[Token(Token = "0x17000322")]
		EventVisibility Visibility
		{
			[Token(Token = "0x60017C4")]
			get;
		}
	}
}
