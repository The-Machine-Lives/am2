using System;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000513")]
	[AttributeAttribute(Name = "GroupAttribute", RVA = "0x81FE68", Offset = "0x81FE68")]
	public class RDLocalNotificationEvent : BaseEntityDocument
	{
		[Token(Token = "0x40017C5")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x82FF3C", Offset = "0x82FF3C")]
		public DateTime scheduledTime;

		[Token(Token = "0x40017C6")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "EntityReference", RVA = "0x82FF74", Offset = "0x82FF74")]
		public string localNotifReference;

		[Token(Token = "0x60026A8")]
		[Address(RVA = "0xA816C8", Offset = "0xA816C8", VA = "0xA816C8")]
		public RDLocalNotificationEvent(string _refName)
		{
		}
	}
}
