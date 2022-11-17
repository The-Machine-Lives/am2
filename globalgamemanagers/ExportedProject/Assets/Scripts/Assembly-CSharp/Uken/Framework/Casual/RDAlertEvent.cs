using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004EB")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81FCB4", Offset = "0x81FCB4")]
	public class RDAlertEvent : BaseEntityDocument
	{
		[Token(Token = "0x4001761")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "EntityReference", RVA = "0x82F86C", Offset = "0x82F86C")]
		public string eventSchedule;

		[Token(Token = "0x4001762")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "EntityReference", RVA = "0x82F8A4", Offset = "0x82F8A4")]
		public List<string> userSegments;

		[Token(Token = "0x4001763")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "EntityReference", RVA = "0x82F8DC", Offset = "0x82F8DC")]
		public string alertReference;

		[Token(Token = "0x4001764")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "EntityReference", RVA = "0x82F914", Offset = "0x82F914")]
		public string hudIconReference;

		[Token(Token = "0x4001765")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "EntityReference", RVA = "0x82F94C", Offset = "0x82F94C")]
		public string lobbyBannerReference;

		[Token(Token = "0x60025EF")]
		[Address(RVA = "0xA80D4C", Offset = "0xA80D4C", VA = "0xA80D4C")]
		public RDAlertEvent()
		{
		}
	}
}
