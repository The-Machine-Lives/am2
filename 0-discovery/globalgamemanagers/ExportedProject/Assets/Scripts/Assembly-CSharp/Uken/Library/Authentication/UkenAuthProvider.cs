using System;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.Authentication
{
	[Token(Token = "0x200048E")]
	public class UkenAuthProvider : UkenController
	{
		[Token(Token = "0x6002163")]
		[Address(RVA = "0xAFC46C", Offset = "0xAFC46C", VA = "0xAFC46C", Slot = "10")]
		public virtual void GetAuthenticationToken(Action<bool, string> onQueryComplete, bool allowAutoLogin = true)
		{
		}

		[Token(Token = "0x6002164")]
		[Address(RVA = "0xAFC4DC", Offset = "0xAFC4DC", VA = "0xAFC4DC", Slot = "11")]
		public virtual void GetUserID(Action<bool, string> onQueryComplete, bool allowAutoLogin = true)
		{
		}

		[Token(Token = "0x6002165")]
		[Address(RVA = "0xAFC54C", Offset = "0xAFC54C", VA = "0xAFC54C")]
		public UkenAuthProvider()
		{
		}
	}
}
