using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004D3")]
	public class FacebookSelfData : FacebookUserData
	{
		[Token(Token = "0x2000831")]
		public class AgeRange
		{
			[Token(Token = "0x400238B")]
			[FieldOffset(Offset = "0x10")]
			public int min;

			[Token(Token = "0x400238C")]
			[FieldOffset(Offset = "0x14")]
			public int max;

			[Token(Token = "0x600332D")]
			[Address(RVA = "0xA67D90", Offset = "0xA67D90", VA = "0xA67D90")]
			public AgeRange()
			{
			}
		}

		[Token(Token = "0x400169C")]
		[FieldOffset(Offset = "0x30")]
		public AgeRange age_range;

		[Token(Token = "0x400169D")]
		[FieldOffset(Offset = "0x38")]
		public string gender;

		[Token(Token = "0x400169E")]
		[FieldOffset(Offset = "0x40")]
		public string email;

		[Token(Token = "0x400169F")]
		[FieldOffset(Offset = "0x48")]
		public string locale;

		[Token(Token = "0x40016A0")]
		[FieldOffset(Offset = "0x50")]
		public string timezone;

		[Token(Token = "0x40016A1")]
		[FieldOffset(Offset = "0x58")]
		public FacebookFriendsQueryResult friends;

		[Token(Token = "0x6002463")]
		[Address(RVA = "0xA67D2C", Offset = "0xA67D2C", VA = "0xA67D2C")]
		public FacebookSelfData()
		{
		}
	}
}
