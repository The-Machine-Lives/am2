using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x20003B8")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F8E0", Offset = "0x81F8E0")]
	public class RDGlobalLeaderboard : BaseEntityDocument
	{
		[Token(Token = "0x40011CD")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82DF4C", Offset = "0x82DF4C")]
		[Attribute(Name = "EntityReference", RVA = "0x82DF4C", Offset = "0x82DF4C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82DF4C", Offset = "0x82DF4C")]
		public string repeatingSchedule;

		[Token(Token = "0x40011CE")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82DFC0", Offset = "0x82DFC0")]
		[Attribute(Name = "EntityReference", RVA = "0x82DFC0", Offset = "0x82DFC0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82DFC0", Offset = "0x82DFC0")]
		public string rewards;

		[Token(Token = "0x40011CF")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "MultiEntityReference", RVA = "0x82E034", Offset = "0x82E034")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82E034", Offset = "0x82E034")]
		public string trackedItem;

		[Token(Token = "0x40011D0")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82E0F0", Offset = "0x82E0F0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82E0F0", Offset = "0x82E0F0")]
		public string howToPlace;

		[Token(Token = "0x40011D1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82E140", Offset = "0x82E140")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82E140", Offset = "0x82E140")]
		public string description;

		[Token(Token = "0x6001CAD")]
		[Address(RVA = "0x9BA55C", Offset = "0x9BA55C", VA = "0x9BA55C")]
		public RDGlobalLeaderboard()
		{
		}
	}
}
