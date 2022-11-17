using System;
using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x200003D")]
	public class FacebookConnect : BaseEvent
	{
		[Token(Token = "0x40000F1")]
		private const string TYPE = "facebook_connect";

		[Token(Token = "0x40000F2")]
		private const string NAME = "data";

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x16D83E8", Offset = "0x16D83E8", VA = "0x16D83E8")]
		public FacebookConnect(string fbFirstName, string fbLastName, string fbName, string fbGender, string fbId, string fbLocale, string fbAgeRangeMin, string fbEmail, string fbTimezone)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x16D8584", Offset = "0x16D8584", VA = "0x16D8584", Slot = "5")]
		public override bool ValidateChild()
		{
			return default(bool);
		}
	}
}
