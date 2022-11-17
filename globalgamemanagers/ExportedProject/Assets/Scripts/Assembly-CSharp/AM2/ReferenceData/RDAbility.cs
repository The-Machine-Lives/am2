using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200031E")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81EC68", Offset = "0x81EC68")]
	public class RDAbility : BaseEntityDocument
	{
		[Token(Token = "0x4000F6F")]
		private const int c_maxCostResources = 3;

		[Token(Token = "0x4000F70")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827428", Offset = "0x827428")]
		public bool giveAbilityOnAcquireAmmo;

		[Token(Token = "0x4000F71")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "MultiEntityReference", RVA = "0x827460", Offset = "0x827460")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827460", Offset = "0x827460")]
		public string ammo;

		[Token(Token = "0x4000F72")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82750C", Offset = "0x82750C")]
		public string readableName;

		[Token(Token = "0x4000F73")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827544", Offset = "0x827544")]
		public string readableAmmoName;

		[Token(Token = "0x4000F74")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82757C", Offset = "0x82757C")]
		public string description;

		[Token(Token = "0x4000F75")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x8275B4", Offset = "0x8275B4")]
		[Attribute(Name = "MultiEntityReference", RVA = "0x8275B4", Offset = "0x8275B4")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8275B4", Offset = "0x8275B4")]
		public List<string> friendlyEffects;

		[Token(Token = "0x4000F76")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x827674", Offset = "0x827674")]
		[Attribute(Name = "MultiEntityReference", RVA = "0x827674", Offset = "0x827674")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827674", Offset = "0x827674")]
		public List<string> enemyEffects;

		[Token(Token = "0x4000F77")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x827734", Offset = "0x827734")]
		[Attribute(Name = "MultiEntityReference", RVA = "0x827734", Offset = "0x827734")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827734", Offset = "0x827734")]
		public List<string> startingZoneEffects;

		[Token(Token = "0x4000F78")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x8277F4", Offset = "0x8277F4")]
		[Attribute(Name = "MultiEntityReference", RVA = "0x8277F4", Offset = "0x8277F4")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8277F4", Offset = "0x8277F4")]
		public List<string> startingSceneEffects;

		[Token(Token = "0x4000F79")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8278B4", Offset = "0x8278B4")]
		public float cooldownInSeconds;

		[Token(Token = "0x4000F7A")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8278EC", Offset = "0x8278EC")]
		public float castTimeInSeconds;

		[Token(Token = "0x4000F7B")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "EntityReference", RVA = "0x827924", Offset = "0x827924")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827924", Offset = "0x827924")]
		public string levellableCooldownInSeconds;

		[Token(Token = "0x4000F7C")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "EntityReference", RVA = "0x827984", Offset = "0x827984")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827984", Offset = "0x827984")]
		public string levellableCastTimeInSeconds;

		[Token(Token = "0x4000F7D")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "EntityReference", RVA = "0x8279E4", Offset = "0x8279E4")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8279E4", Offset = "0x8279E4")]
		public string levellableAccuracy;

		[Token(Token = "0x4000F7E")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "EntityReference", RVA = "0x827A44", Offset = "0x827A44")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827A44", Offset = "0x827A44")]
		public List<string> costResources;

		[Token(Token = "0x4000F7F")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827AA4", Offset = "0x827AA4")]
		public int maxLevel;

		[Token(Token = "0x4000F80")]
		[FieldOffset(Offset = "0xA4")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827ADC", Offset = "0x827ADC")]
		public float channelTimeInSeconds;

		[Token(Token = "0x4000F81")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827B14", Offset = "0x827B14")]
		public float accuracyPercent;

		[Token(Token = "0x4000F82")]
		[FieldOffset(Offset = "0xAC")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827B4C", Offset = "0x827B4C")]
		public bool ignoresDodge;

		[Token(Token = "0x4000F83")]
		[FieldOffset(Offset = "0xAD")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827B84", Offset = "0x827B84")]
		public bool executeFriendlyEffectsOnDodge;

		[Token(Token = "0x4000F84")]
		[FieldOffset(Offset = "0xAE")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827BBC", Offset = "0x827BBC")]
		public bool interruptable;

		[Token(Token = "0x4000F85")]
		[FieldOffset(Offset = "0xAF")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827BF4", Offset = "0x827BF4")]
		public bool channelingInterruptable;

		[Token(Token = "0x4000F86")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827C2C", Offset = "0x827C2C")]
		public bool showCastingBar;

		[Token(Token = "0x4000F87")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "EntityReference", RVA = "0x827C64", Offset = "0x827C64")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827C64", Offset = "0x827C64")]
		public string channelEndAbility;

		[Token(Token = "0x4000F88")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "EntityReference", RVA = "0x827CC4", Offset = "0x827CC4")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827CC4", Offset = "0x827CC4")]
		public string deathAbility;

		[Token(Token = "0x4000F89")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "EntityReference", RVA = "0x827D24", Offset = "0x827D24")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827D24", Offset = "0x827D24")]
		public string damageAbility;

		[Token(Token = "0x4000F8A")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "EntityReference", RVA = "0x827D84", Offset = "0x827D84")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827D84", Offset = "0x827D84")]
		public string tag;

		[Token(Token = "0x6001943")]
		[Address(RVA = "0x9BA07C", Offset = "0x9BA07C", VA = "0x9BA07C")]
		public RDAbility(string inReference)
		{
		}
	}
}
