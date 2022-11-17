using Il2CppDummyDll;

[Token(Token = "0x20000BB")]
public class GooglePlayDataStore
{
	[Token(Token = "0x400030F")]
	[FieldOffset(Offset = "0x10")]
	public bool sawAutoSignin;

	[Token(Token = "0x4000310")]
	[FieldOffset(Offset = "0x11")]
	public bool isLoggedIn;

	[Token(Token = "0x4000311")]
	[FieldOffset(Offset = "0x12")]
	public bool triedSetAgeOnce;

	[Token(Token = "0x4000312")]
	[FieldOffset(Offset = "0x13")]
	public bool triedSetAgeTwice;

	[Token(Token = "0x4000313")]
	[FieldOffset(Offset = "0x18")]
	public double timeSeen;

	[Token(Token = "0x4000314")]
	[FieldOffset(Offset = "0x20")]
	public bool confirmedOver18;

	[Token(Token = "0x600047F")]
	[Address(RVA = "0x9D7E6C", Offset = "0x9D7E6C", VA = "0x9D7E6C")]
	public GooglePlayDataStore()
	{
	}
}
