using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000512")]
	public class RDLocalNotification : BaseEntityDocument
	{
		[Token(Token = "0x40017C2")]
		[FieldOffset(Offset = "0x30")]
		public int localNotificationId;

		[Token(Token = "0x40017C3")]
		[FieldOffset(Offset = "0x38")]
		public string message;

		[Token(Token = "0x40017C4")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82FF04", Offset = "0x82FF04")]
		public float timeOffset;

		[Token(Token = "0x60026A7")]
		[Address(RVA = "0xA81694", Offset = "0xA81694", VA = "0xA81694")]
		public RDLocalNotification(string _refName)
		{
		}
	}
}
