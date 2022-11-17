using Il2CppDummyDll;

[Token(Token = "0x200016A")]
public class InventoryErrorObject
{
	[Token(Token = "0x40008C7")]
	[FieldOffset(Offset = "0x10")]
	public long timestamp;

	[Token(Token = "0x40008C8")]
	[FieldOffset(Offset = "0x18")]
	public string status;

	[Token(Token = "0x40008C9")]
	[FieldOffset(Offset = "0x20")]
	public string message;

	[Token(Token = "0x60009EB")]
	[Address(RVA = "0x98E37C", Offset = "0x98E37C", VA = "0x98E37C")]
	public InventoryErrorObject()
	{
	}
}
