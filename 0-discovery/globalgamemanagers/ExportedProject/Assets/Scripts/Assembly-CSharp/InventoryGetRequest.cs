using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x200016C")]
public class InventoryGetRequest
{
	[Token(Token = "0x40008D7")]
	[FieldOffset(Offset = "0x10")]
	public string token;

	[Token(Token = "0x40008D8")]
	[FieldOffset(Offset = "0x18")]
	public List<Dictionary<string, object>> items;

	[Token(Token = "0x40008D9")]
	[FieldOffset(Offset = "0x20")]
	public List<string> revisions;

	[Token(Token = "0x6000A04")]
	[Address(RVA = "0x98E384", Offset = "0x98E384", VA = "0x98E384")]
	public InventoryGetRequest()
	{
	}
}
