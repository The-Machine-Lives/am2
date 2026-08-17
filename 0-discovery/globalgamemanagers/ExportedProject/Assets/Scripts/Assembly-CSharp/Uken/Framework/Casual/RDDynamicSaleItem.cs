using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000529")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81FEA0", Offset = "0x81FEA0")]
	public class RDDynamicSaleItem : BaseEntityDocument
	{
		[Token(Token = "0x4001843")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "EntityReference", RVA = "0x8307C0", Offset = "0x8307C0")]
		public string hudIconReference;

		[Token(Token = "0x4001844")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "EntityReference", RVA = "0x8307F8", Offset = "0x8307F8")]
		public string lobbyBannerReference;

		[Token(Token = "0x4001845")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DropdownNameAttribute", RVA = "0x830830", Offset = "0x830830")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x830830", Offset = "0x830830")]
		public List<int> bingoSurfacePoints;

		[Token(Token = "0x4001846")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "EntityReference", RVA = "0x830880", Offset = "0x830880")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x830880", Offset = "0x830880")]
		public List<string> saleItemReferences;

		[Token(Token = "0x4001847")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "EntityReference", RVA = "0x8308D0", Offset = "0x8308D0")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x8308D0", Offset = "0x8308D0")]
		public string scheduleRef;

		[Token(Token = "0x4001848")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "EntityReference", RVA = "0x830920", Offset = "0x830920")]
		public List<string> userSegments;

		[Token(Token = "0x4001849")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x830958", Offset = "0x830958")]
		public int viewDuration;

		[Token(Token = "0x400184A")]
		[FieldOffset(Offset = "0x64")]
		public int displayPriority;

		[Token(Token = "0x400184B")]
		[FieldOffset(Offset = "0x68")]
		public int viewLimit;

		[Token(Token = "0x400184C")]
		[FieldOffset(Offset = "0x6C")]
		public int viewIntervalInMinutes;

		[Token(Token = "0x400184D")]
		[FieldOffset(Offset = "0x70")]
		public bool isUnlimited;

		[Token(Token = "0x400184E")]
		[FieldOffset(Offset = "0x74")]
		public int purchaseLimit;

		[Token(Token = "0x400184F")]
		[FieldOffset(Offset = "0x78")]
		public bool useGlobalScarcity;

		[Token(Token = "0x4001850")]
		[FieldOffset(Offset = "0x7C")]
		public int startingQuantity;

		[Token(Token = "0x4001851")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x830990", Offset = "0x830990")]
		public string timerDescriptionFormatString;

		[Token(Token = "0x4001852")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8309A4", Offset = "0x8309A4")]
		public string title;

		[Token(Token = "0x4001853")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8309DC", Offset = "0x8309DC")]
		public string subtitle;

		[Token(Token = "0x4001854")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x830A14", Offset = "0x830A14")]
		public bool excludeIfNewSalesActive;

		[Token(Token = "0x6002794")]
		[Address(RVA = "0xA80E1C", Offset = "0xA80E1C", VA = "0xA80E1C")]
		public List<int> SurfacePoints()
		{
			return null;
		}

		[Token(Token = "0x6002795")]
		[Address(RVA = "0xA80E8C", Offset = "0xA80E8C", VA = "0xA80E8C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6002796")]
		[Address(RVA = "0xA80FCC", Offset = "0xA80FCC", VA = "0xA80FCC")]
		public RDDynamicSaleItem()
		{
		}
	}
}
