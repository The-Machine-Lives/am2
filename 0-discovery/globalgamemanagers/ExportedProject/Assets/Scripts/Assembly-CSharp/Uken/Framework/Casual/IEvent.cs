using System;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200055A")]
	public interface IEvent
	{
		[Token(Token = "0x60028FB")]
		bool IsResourceActive();

		[Token(Token = "0x60028FC")]
		DateTime ResourceStartTime();

		[Token(Token = "0x60028FD")]
		DateTime ResourceEndTime();

		[Token(Token = "0x60028FE")]
		int GetNotificationCount();

		[Token(Token = "0x60028FF")]
		string GetSpecialText();

		[Token(Token = "0x6002900")]
		bool InsertTemporarySchedule(DateTime startTime, DateTime endTime);
	}
}
