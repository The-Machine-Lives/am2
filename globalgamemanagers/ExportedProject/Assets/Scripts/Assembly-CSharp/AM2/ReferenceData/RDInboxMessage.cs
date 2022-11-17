using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000377")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F3A0", Offset = "0x81F3A0")]
	public class RDInboxMessage : BaseEntityDocument
	{
		[Token(Token = "0x4001100")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82B8C0", Offset = "0x82B8C0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82B8C0", Offset = "0x82B8C0")]
		public string subject;

		[Token(Token = "0x4001101")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82B910", Offset = "0x82B910")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82B910", Offset = "0x82B910")]
		public string body;

		[Token(Token = "0x4001102")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82B960", Offset = "0x82B960")]
		public string rewardItemReference;

		[Token(Token = "0x4001103")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82B998", Offset = "0x82B998")]
		public long rewardAmount;

		[Token(Token = "0x4001104")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "EntityReference", RVA = "0x82B9D0", Offset = "0x82B9D0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82B9D0", Offset = "0x82B9D0")]
		public string eventSchedule;

		[Token(Token = "0x6001B85")]
		[Address(RVA = "0x9BA5C4", Offset = "0x9BA5C4", VA = "0x9BA5C4")]
		public RDInboxMessage(string inReference)
		{
		}
	}
}
