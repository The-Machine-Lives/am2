using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000347")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81EF78", Offset = "0x81EF78")]
	public class RDSpeedBooster : BaseEntityDocument
	{
		[Token(Token = "0x4000FF9")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x828E60", Offset = "0x828E60")]
		public int durationInSeconds;

		[Token(Token = "0x4000FFA")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x828E98", Offset = "0x828E98")]
		public long speedUpPercent;

		[Token(Token = "0x4000FFB")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "EntityReference", RVA = "0x828ED0", Offset = "0x828ED0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x828ED0", Offset = "0x828ED0")]
		public List<string> onUseRewards;

		[Token(Token = "0x4000FFC")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x828F30", Offset = "0x828F30")]
		public string costItem;

		[Token(Token = "0x4000FFD")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x828F68", Offset = "0x828F68")]
		public long costAmount;

		[Token(Token = "0x4000FFE")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x828FA0", Offset = "0x828FA0")]
		public string readableName;

		[Token(Token = "0x4000FFF")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x828FD8", Offset = "0x828FD8")]
		public string infoText;

		[Token(Token = "0x6001A11")]
		[Address(RVA = "0x9BAADC", Offset = "0x9BAADC", VA = "0x9BAADC")]
		public RDSpeedBooster(string _ref)
		{
		}
	}
}
