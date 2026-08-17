using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.ReferenceData
{
	[Token(Token = "0x2000464")]
	public class BaseEntityDocument
	{
		[Token(Token = "0x400145E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82E6C8", Offset = "0x82E6C8")]
		public string reference;

		[Token(Token = "0x400145F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82E700", Offset = "0x82E700")]
		public bool enabled;

		[Token(Token = "0x4001460")]
		[FieldOffset(Offset = "0x20")]
		public List<VersionRecord> minimum_version;

		[Token(Token = "0x4001461")]
		[FieldOffset(Offset = "0x28")]
		public List<VersionRecord> maximum_version;

		[Token(Token = "0x60020C0")]
		[Address(RVA = "0xB348D8", Offset = "0xB348D8", VA = "0xB348D8", Slot = "4")]
		public virtual void PostProcessData()
		{
		}

		[Token(Token = "0x60020C1")]
		[Address(RVA = "0xB348DC", Offset = "0xB348DC", VA = "0xB348DC")]
		public BaseEntityDocument()
		{
		}
	}
}
