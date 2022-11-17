using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004EA")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81FC7C", Offset = "0x81FC7C")]
	public class RDAlert : BaseEntityDocument
	{
		[Token(Token = "0x4001757")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "EntityReference", RVA = "0x82F624", Offset = "0x82F624")]
		[Attribute(Name = "DeprecatedAttribute", RVA = "0x82F624", Offset = "0x82F624")]
		public string eventSchedule;

		[Token(Token = "0x4001758")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "EntityReference", RVA = "0x82F684", Offset = "0x82F684")]
		public List<string> userSegments;

		[Token(Token = "0x4001759")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82F6BC", Offset = "0x82F6BC")]
		public int maxShowCount;

		[Token(Token = "0x400175A")]
		[FieldOffset(Offset = "0x44")]
		public bool newUserOnly;

		[Token(Token = "0x400175B")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82F6F4", Offset = "0x82F6F4")]
		public string imageUrl;

		[Token(Token = "0x400175C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DropdownNameAttribute", RVA = "0x82F72C", Offset = "0x82F72C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82F72C", Offset = "0x82F72C")]
		public string iconPath;

		[Token(Token = "0x400175D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82F78C", Offset = "0x82F78C")]
		public string titleText;

		[Token(Token = "0x400175E")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82F7C4", Offset = "0x82F7C4")]
		public string middleText;

		[Token(Token = "0x400175F")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82F7FC", Offset = "0x82F7FC")]
		public string bottomText;

		[Token(Token = "0x4001760")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82F834", Offset = "0x82F834")]
		public int priority;

		[Token(Token = "0x60025EE")]
		[Address(RVA = "0xA80CEC", Offset = "0xA80CEC", VA = "0xA80CEC")]
		public RDAlert()
		{
		}
	}
}
