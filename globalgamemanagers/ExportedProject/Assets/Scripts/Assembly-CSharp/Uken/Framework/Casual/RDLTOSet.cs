using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200052A")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81FED8", Offset = "0x81FED8")]
	public class RDLTOSet : BaseEntityDocument
	{
		[Token(Token = "0x200084B")]
		public enum LTOIncrementMethod
		{
			[Token(Token = "0x40023D0")]
			ExpiryWithoutPurchase = 0,
			[Token(Token = "0x40023D1")]
			Purchase = 1
		}

		[Token(Token = "0x4001855")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "EntityReference", RVA = "0x830A4C", Offset = "0x830A4C")]
		public List<string> userSegments;

		[Token(Token = "0x4001856")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DropdownNameAttribute", RVA = "0x830A84", Offset = "0x830A84")]
		public List<int> surfacePoints;

		[Token(Token = "0x4001857")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "EntityReference", RVA = "0x830ABC", Offset = "0x830ABC")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x830ABC", Offset = "0x830ABC")]
		public List<string> ltoReferences;

		[Token(Token = "0x4001858")]
		[FieldOffset(Offset = "0x48")]
		public LTOIncrementMethod incrementMethod;

		[Token(Token = "0x4001859")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x830B0C", Offset = "0x830B0C")]
		public string assetBundle;

		[Token(Token = "0x400185A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x830B44", Offset = "0x830B44")]
		public string prefabPath;

		[Token(Token = "0x400185B")]
		[FieldOffset(Offset = "0x60")]
		public string title;

		[Token(Token = "0x400185C")]
		[FieldOffset(Offset = "0x68")]
		public string description;

		[Token(Token = "0x400185D")]
		[FieldOffset(Offset = "0x70")]
		public string backgroundPath;

		[Token(Token = "0x400185E")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x830B7C", Offset = "0x830B7C")]
		public List<string> customImages;

		[Token(Token = "0x400185F")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x830BB4", Offset = "0x830BB4")]
		public List<string> customTexts;

		[Token(Token = "0x6002797")]
		[Address(RVA = "0xA813FC", Offset = "0xA813FC", VA = "0xA813FC")]
		public List<int> SurfacePoints()
		{
			return null;
		}

		[Token(Token = "0x6002798")]
		[Address(RVA = "0xA8146C", Offset = "0xA8146C", VA = "0xA8146C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6002799")]
		[Address(RVA = "0xA815AC", Offset = "0xA815AC", VA = "0xA815AC")]
		public RDLTOSet()
		{
		}
	}
}
