using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000552")]
	[Attribute(Name = "GroupAttribute", RVA = "0x820140", Offset = "0x820140")]
	public class RDEventTicketItem : BaseEntityDocument, IRDItem
	{
		[Token(Token = "0x400195D")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8322AC", Offset = "0x8322AC")]
		public string displayName;

		[Token(Token = "0x400195E")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DepotReference", RVA = "0x8322E4", Offset = "0x8322E4")]
		public string eventDepot;

		[Token(Token = "0x400195F")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DynamicEntityReference", RVA = "0x832368", Offset = "0x832368")]
		public string itemReference;

		[Token(Token = "0x4001960")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DeprecatedAttribute", RVA = "0x83237C", Offset = "0x83237C")]
		[Attribute(Name = "DropdownNameAttribute", RVA = "0x83237C", Offset = "0x83237C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x83237C", Offset = "0x83237C")]
		public int eventType;

		[Token(Token = "0x4001961")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DeprecatedAttribute", RVA = "0x8323EC", Offset = "0x8323EC")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8323EC", Offset = "0x8323EC")]
		public string eventRef;

		[Token(Token = "0x4001962")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x832438", Offset = "0x832438")]
		public int duration;

		[Token(Token = "0x4001963")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x832470", Offset = "0x832470")]
		public string iconPath;

		[Token(Token = "0x4001964")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "EntityReference", RVA = "0x8324A8", Offset = "0x8324A8")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8324A8", Offset = "0x8324A8")]
		public string alertRef;

		[Token(Token = "0x4001965")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x832508", Offset = "0x832508")]
		public float eventTicketScalar;

		[Token(Token = "0x60028D3")]
		[Address(RVA = "0xA810BC", Offset = "0xA810BC", VA = "0xA810BC")]
		public RDEventTicketItem(string _refName)
		{
		}
	}
}
