using System;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200055C")]
	public interface ILocalNotification
	{
		[Token(Token = "0x17000744")]
		string notificationReference
		{
			[Token(Token = "0x6002902")]
			get;
		}

		[Token(Token = "0x6002903")]
		DateTime GetNotificationTime();
	}
}
