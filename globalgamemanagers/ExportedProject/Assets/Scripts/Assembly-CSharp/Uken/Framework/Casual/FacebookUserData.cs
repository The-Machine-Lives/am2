using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004D2")]
	public class FacebookUserData
	{
		[Token(Token = "0x4001698")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4001699")]
		[FieldOffset(Offset = "0x18")]
		public string first_name;

		[Token(Token = "0x400169A")]
		[FieldOffset(Offset = "0x20")]
		public string last_name;

		[Token(Token = "0x400169B")]
		[FieldOffset(Offset = "0x28")]
		public bool installed;

		[Token(Token = "0x6002461")]
		[Address(RVA = "0xA67DF0", Offset = "0xA67DF0", VA = "0xA67DF0")]
		public string GetFullName()
		{
			return null;
		}

		[Token(Token = "0x6002462")]
		[Address(RVA = "0xA67D98", Offset = "0xA67D98", VA = "0xA67D98")]
		public FacebookUserData()
		{
		}
	}
}
