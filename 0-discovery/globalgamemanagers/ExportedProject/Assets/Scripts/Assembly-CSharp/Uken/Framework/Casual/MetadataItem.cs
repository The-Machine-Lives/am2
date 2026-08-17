using System;
using Il2CppDummyDll;
using Uken.Library.Inventory;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000507")]
	public class MetadataItem : Item
	{
		[Token(Token = "0x2000844")]
		private static class MetadataTraits
		{
			[Token(Token = "0x40023AC")]
			public const string mc_sLastClaimed = "last_claimed";

			[Token(Token = "0x40023AD")]
			public const string mc_sActivatedAt = "activated_at";
		}

		[Token(Token = "0x40017AB")]
		public new const string mc_sItemType = "MetadataItem";

		[Token(Token = "0x40017AC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int DateUnset;

		[Token(Token = "0x600267E")]
		[Address(RVA = "0xA73978", Offset = "0xA73978", VA = "0xA73978")]
		public int? LastClaimTime()
		{
			return null;
		}

		[Token(Token = "0x600267F")]
		[Address(RVA = "0xA73A34", Offset = "0xA73A34", VA = "0xA73A34")]
		public int ActivatedAt()
		{
			return default(int);
		}

		[Token(Token = "0x6002680")]
		[Address(RVA = "0xA73AF4", Offset = "0xA73AF4", VA = "0xA73AF4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x83A0BC", Offset = "0x83A0BC")]
		public void SetLastClaimedAt(int epoch)
		{
		}

		[Token(Token = "0x6002681")]
		[Address(RVA = "0xA73B84", Offset = "0xA73B84", VA = "0xA73B84")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x83A0F4", Offset = "0x83A0F4")]
		public void SetActivatedAt(int epoch)
		{
		}

		[Token(Token = "0x6002682")]
		[Address(RVA = "0xA73C14", Offset = "0xA73C14", VA = "0xA73C14")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x83A12C", Offset = "0x83A12C")]
		public void SetTraitValue(string traitKey, string value)
		{
		}

		[Token(Token = "0x6002683")]
		[Address(RVA = "0xA73C1C", Offset = "0xA73C1C", VA = "0xA73C1C")]
		public void ClearTrait(string traitKey)
		{
		}

		[Token(Token = "0x6002684")]
		[Address(RVA = "0xA73CAC", Offset = "0xA73CAC", VA = "0xA73CAC")]
		public float GetTraitFloat(string traitName)
		{
			return default(float);
		}

		[Token(Token = "0x6002685")]
		[Address(RVA = "0xA73CB8", Offset = "0xA73CB8", VA = "0xA73CB8")]
		public double GetTraitDouble(string traitName)
		{
			return default(double);
		}

		[Token(Token = "0x6002686")]
		[Address(RVA = "0xA73CC4", Offset = "0xA73CC4", VA = "0xA73CC4")]
		public int GetTraitInt(string traitName)
		{
			return default(int);
		}

		[Token(Token = "0x6002687")]
		[Address(RVA = "0xA73CD0", Offset = "0xA73CD0", VA = "0xA73CD0")]
		public long GetTraitLong(string traitName)
		{
			return default(long);
		}

		[Token(Token = "0x6002688")]
		[Address(RVA = "0xA73CDC", Offset = "0xA73CDC", VA = "0xA73CDC")]
		public string GetTraitString(string traitName)
		{
			return null;
		}

		[Token(Token = "0x6002689")]
		[Address(RVA = "0xA73D40", Offset = "0xA73D40", VA = "0xA73D40")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x83A164", Offset = "0x83A164")]
		public DateTime GetTraitDateTime(string traitName)
		{
			return default(DateTime);
		}

		[Token(Token = "0x600268A")]
		[Address(RVA = "0xA74058", Offset = "0xA74058", VA = "0xA74058")]
		public MetadataItem()
		{
		}
	}
}
