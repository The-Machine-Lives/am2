using Il2CppDummyDll;

namespace Uken.Library.Inventory
{
	[Token(Token = "0x2000452")]
	public class ItemMinimalDetails
	{
		[Token(Token = "0x4001404")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E5B8", Offset = "0x82E5B8")]
		private readonly string _003CitemType_003Ek__BackingField;

		[Token(Token = "0x4001405")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E5C8", Offset = "0x82E5C8")]
		private readonly string _003CreadableName_003Ek__BackingField;

		[Token(Token = "0x4001406")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E5D8", Offset = "0x82E5D8")]
		private readonly string _003CresearchName_003Ek__BackingField;

		[Token(Token = "0x4001407")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E5E8", Offset = "0x82E5E8")]
		private readonly string _003CitemDescription_003Ek__BackingField;

		[Token(Token = "0x170005B1")]
		public string itemType
		{
			[Token(Token = "0x6001FED")]
			[Address(RVA = "0xB9C778", Offset = "0xB9C778", VA = "0xB9C778")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839164", Offset = "0x839164")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005B2")]
		public string readableName
		{
			[Token(Token = "0x6001FEE")]
			[Address(RVA = "0xBA64FC", Offset = "0xBA64FC", VA = "0xBA64FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839174", Offset = "0x839174")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005B3")]
		public string researchName
		{
			[Token(Token = "0x6001FEF")]
			[Address(RVA = "0xBA6504", Offset = "0xBA6504", VA = "0xBA6504")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839184", Offset = "0x839184")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005B4")]
		public string itemDescription
		{
			[Token(Token = "0x6001FF0")]
			[Address(RVA = "0xBA650C", Offset = "0xBA650C", VA = "0xBA650C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839194", Offset = "0x839194")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001FF1")]
		[Address(RVA = "0xB9D79C", Offset = "0xB9D79C", VA = "0xB9D79C")]
		public ItemMinimalDetails(string inItemType, string inReadableName, string inItemDescription = "", string inResearchName = "")
		{
		}
	}
}
