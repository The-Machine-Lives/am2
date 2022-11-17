using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Serializable]
	[Token(Token = "0x20004B5")]
	public class AM2MessageSave
	{
		[Token(Token = "0x40015FD")]
		[FieldOffset(Offset = "0x10")]
		public List<string> oldMessages;

		[Token(Token = "0x6002371")]
		[Address(RVA = "0xA1EE4C", Offset = "0xA1EE4C", VA = "0xA1EE4C")]
		public AM2MessageSave()
		{
		}
	}
}
