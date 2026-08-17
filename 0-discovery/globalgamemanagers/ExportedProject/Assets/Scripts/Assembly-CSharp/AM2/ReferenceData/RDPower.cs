using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200035F")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F170", Offset = "0x81F170")]
	public class RDPower : BaseEntityDocument
	{
		[Token(Token = "0x400106B")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82A024", Offset = "0x82A024")]
		public float powerDecayRate;

		[Token(Token = "0x400106C")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82A05C", Offset = "0x82A05C")]
		public float buttonDecelerationTime;

		[Token(Token = "0x400106D")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82A094", Offset = "0x82A094")]
		public float buttonPressSpeed;

		[Token(Token = "0x400106E")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82A0CC", Offset = "0x82A0CC")]
		public float buttonReleaseSpeed;

		[Token(Token = "0x400106F")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82A104", Offset = "0x82A104")]
		public int framesToTreatPowerAsPressed;

		[Token(Token = "0x4001070")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82A13C", Offset = "0x82A13C")]
		public bool isPowerGrowthConstant;

		[Token(Token = "0x4001071")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82A174", Offset = "0x82A174")]
		public float powerGrowthTimeInSeconds;

		[Token(Token = "0x4001072")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82A1AC", Offset = "0x82A1AC")]
		public bool isPowerDecayUpgradable;

		[Token(Token = "0x4001073")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82A1E4", Offset = "0x82A1E4")]
		public float sliderRateToHideTapAndHoldText;

		[Token(Token = "0x4001074")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82A21C", Offset = "0x82A21C")]
		[Attribute(Name = "EntityReference", RVA = "0x82A21C", Offset = "0x82A21C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82A21C", Offset = "0x82A21C")]
		public string powerSubTab;

		[Token(Token = "0x4001075")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82A290", Offset = "0x82A290")]
		[Attribute(Name = "EntityReference", RVA = "0x82A290", Offset = "0x82A290")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82A290", Offset = "0x82A290")]
		public string equipmentSubTab;

		[Token(Token = "0x4001076")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82A304", Offset = "0x82A304")]
		[Attribute(Name = "EntityReference", RVA = "0x82A304", Offset = "0x82A304")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82A304", Offset = "0x82A304")]
		public string prestigeSubTab;

		[Token(Token = "0x6001A98")]
		[Address(RVA = "0x9BA66C", Offset = "0x9BA66C", VA = "0x9BA66C")]
		public RDPower(string _ref)
		{
		}
	}
}
