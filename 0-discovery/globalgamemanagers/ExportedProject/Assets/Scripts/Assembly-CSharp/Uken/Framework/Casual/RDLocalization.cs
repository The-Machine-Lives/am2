using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200050F")]
	public class RDLocalization : BaseEntityDocument
	{
		[Token(Token = "0x2000845")]
		public enum LanguageKey
		{
			[Token(Token = "0x40023AF")]
			English = 0,
			[Token(Token = "0x40023B0")]
			German = 1,
			[Token(Token = "0x40023B1")]
			Spanish = 2,
			[Token(Token = "0x40023B2")]
			French = 3,
			[Token(Token = "0x40023B3")]
			Italian = 4,
			[Token(Token = "0x40023B4")]
			Japanese = 5,
			[Token(Token = "0x40023B5")]
			Korean = 6,
			[Token(Token = "0x40023B6")]
			PT = 7,
			[Token(Token = "0x40023B7")]
			Russian = 8,
			[Token(Token = "0x40023B8")]
			TR = 9,
			[Token(Token = "0x40023B9")]
			TraditionalChinese = 10,
			[Token(Token = "0x40023BA")]
			SimplifiedChinese = 11
		}

		[Token(Token = "0x40017BF")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "TextAreaAttribute", RVA = "0x82FEEC", Offset = "0x82FEEC")]
		public Dictionary<LanguageKey, string> translationData;

		[Token(Token = "0x600269E")]
		[Address(RVA = "0xA816F4", Offset = "0xA816F4", VA = "0xA816F4")]
		public RDLocalization()
		{
		}
	}
}
