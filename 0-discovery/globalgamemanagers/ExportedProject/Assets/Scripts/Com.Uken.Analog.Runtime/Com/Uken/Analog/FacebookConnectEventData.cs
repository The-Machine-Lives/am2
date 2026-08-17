using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x200003E")]
	public class FacebookConnectEventData : EventData
	{
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x18")]
		private string fbFirstName;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x20")]
		private string fbLastName;

		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x28")]
		private string fbName;

		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x30")]
		private string fbGender;

		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x38")]
		private string fbId;

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x40")]
		private string fbLocale;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x48")]
		private string fbAgeRangeMin;

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x50")]
		private string fbEmail;

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x58")]
		private string fbTimezone;

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x16D850C", Offset = "0x16D850C", VA = "0x16D850C")]
		public FacebookConnectEventData(string fbFirstName, string fbLastName, string fbName, string fbGender, string fbId, string fbLocale, string fbAgeRangeMin, string fbEmail, string fbTimezone)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x16D858C", Offset = "0x16D858C", VA = "0x16D858C", Slot = "4")]
		public override void SerializeJson(JsonWriter writer)
		{
		}
	}
}
