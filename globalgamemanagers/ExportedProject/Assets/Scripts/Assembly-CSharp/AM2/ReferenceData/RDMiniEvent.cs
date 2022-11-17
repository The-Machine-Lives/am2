using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200035D")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F138", Offset = "0x81F138")]
	public class RDMiniEvent : BaseEntityDocument
	{
		[Token(Token = "0x4001065")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829F0C", Offset = "0x829F0C")]
		public string readableName;

		[Token(Token = "0x4001066")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829F44", Offset = "0x829F44")]
		public string description;

		[Token(Token = "0x4001067")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829F7C", Offset = "0x829F7C")]
		public uint durationInSeconds;

		[Token(Token = "0x4001068")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "EntityReference", RVA = "0x829FB4", Offset = "0x829FB4")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829FB4", Offset = "0x829FB4")]
		public List<string> effects;

		[Token(Token = "0x6001A8E")]
		[Address(RVA = "0x9BA65C", Offset = "0x9BA65C", VA = "0x9BA65C")]
		public RDMiniEvent(string inReference)
		{
		}
	}
}
