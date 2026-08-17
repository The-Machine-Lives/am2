using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004F0")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81FCEC", Offset = "0x81FCEC")]
	public class RDEventSchedule : BaseEntityDocument
	{
		[Token(Token = "0x4001768")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82F994", Offset = "0x82F994")]
		[Attribute(Name = "EntityReference", RVA = "0x82F994", Offset = "0x82F994")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82F994", Offset = "0x82F994")]
		public List<string> timeSlots;

		[Token(Token = "0x4001769")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "EntityReference", RVA = "0x82FA08", Offset = "0x82FA08")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82FA08", Offset = "0x82FA08")]
		public string repeatingSchedule;

		[Token(Token = "0x400176A")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82FA68", Offset = "0x82FA68")]
		public string comments;

		[Token(Token = "0x6002617")]
		[Address(RVA = "0xA8103C", Offset = "0xA8103C", VA = "0xA8103C")]
		public RDEventSchedule()
		{
		}
	}
}
