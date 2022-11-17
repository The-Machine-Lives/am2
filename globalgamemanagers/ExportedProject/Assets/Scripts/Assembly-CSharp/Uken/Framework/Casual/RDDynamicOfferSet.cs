using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200053B")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81FFB8", Offset = "0x81FFB8")]
	public class RDDynamicOfferSet : BaseEntityDocument
	{
		[Token(Token = "0x200084E")]
		public enum IncrementMethod
		{
			[Token(Token = "0x40023D8")]
			None = 0,
			[Token(Token = "0x40023D9")]
			ExpiryWithoutPurchase = 1,
			[Token(Token = "0x40023DA")]
			Purchase = 2
		}

		[Token(Token = "0x40018C0")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "EntityReference", RVA = "0x830EC0", Offset = "0x830EC0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x830EC0", Offset = "0x830EC0")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x830EC0", Offset = "0x830EC0")]
		public List<string> offers;

		[Token(Token = "0x40018C1")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x830F34", Offset = "0x830F34")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x830F34", Offset = "0x830F34")]
		public IncrementMethod incrementMethod;

		[Token(Token = "0x40018C2")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x830F84", Offset = "0x830F84")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x830F84", Offset = "0x830F84")]
		public int viewLimit;

		[Token(Token = "0x40018C3")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x830FD4", Offset = "0x830FD4")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x830FD4", Offset = "0x830FD4")]
		public int viewIntervalInMinutes;

		[Token(Token = "0x40018C4")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831024", Offset = "0x831024")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x831024", Offset = "0x831024")]
		public bool isUnlimited;

		[Token(Token = "0x40018C5")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831074", Offset = "0x831074")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x831074", Offset = "0x831074")]
		public int purchaseLimit;

		[Token(Token = "0x40018C6")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8310C4", Offset = "0x8310C4")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x8310C4", Offset = "0x8310C4")]
		public bool useGlobalScarcity;

		[Token(Token = "0x40018C7")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831114", Offset = "0x831114")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x831114", Offset = "0x831114")]
		public int startingGlobalQuantity;

		[Token(Token = "0x40018C8")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "EntityReference", RVA = "0x831164", Offset = "0x831164")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831164", Offset = "0x831164")]
		public string hudIcon;

		[Token(Token = "0x40018C9")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "EntityReference", RVA = "0x8311C4", Offset = "0x8311C4")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8311C4", Offset = "0x8311C4")]
		public string lobbyBannerReference;

		[Token(Token = "0x40018CA")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831224", Offset = "0x831224")]
		public string assetBundle;

		[Token(Token = "0x40018CB")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x83125C", Offset = "0x83125C")]
		[Attribute(Name = "DropdownNameAttribute", RVA = "0x83125C", Offset = "0x83125C")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x83125C", Offset = "0x83125C")]
		public string prefabPath;

		[Token(Token = "0x40018CC")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8312D0", Offset = "0x8312D0")]
		public string title;

		[Token(Token = "0x40018CD")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831308", Offset = "0x831308")]
		public string subtitle;

		[Token(Token = "0x40018CE")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831340", Offset = "0x831340")]
		public string description;

		[Token(Token = "0x40018CF")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831378", Offset = "0x831378")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x831378", Offset = "0x831378")]
		public ImageSourceType backgroundType;

		[Token(Token = "0x40018D0")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8313C8", Offset = "0x8313C8")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x8313C8", Offset = "0x8313C8")]
		public string backgroundPath;

		[Token(Token = "0x40018D1")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831418", Offset = "0x831418")]
		public string timerDescription;

		[Token(Token = "0x40018D2")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831450", Offset = "0x831450")]
		public List<string> customImages;

		[Token(Token = "0x40018D3")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831488", Offset = "0x831488")]
		public List<string> customTexts;

		[Token(Token = "0x600280B")]
		[Address(RVA = "0xA80D64", Offset = "0xA80D64", VA = "0xA80D64")]
		public RDDynamicOfferSet()
		{
		}
	}
}
