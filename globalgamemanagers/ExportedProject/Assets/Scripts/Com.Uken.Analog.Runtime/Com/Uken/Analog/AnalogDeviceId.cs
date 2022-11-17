using System;
using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Token(Token = "0x200000B")]
	public class AnalogDeviceId
	{
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x10")]
		private bool initialized;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813DE8", Offset = "0x813DE8")]
		private Guid _003CDeviceID_003Ek__BackingField;

		[Token(Token = "0x1700000B")]
		public static string SavePath
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x16D3EF8", Offset = "0x16D3EF8", VA = "0x16D3EF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000C")]
		public Guid DeviceID
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x16D3F4C", Offset = "0x16D3F4C", VA = "0x16D3F4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815804", Offset = "0x815804")]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x16D3F5C", Offset = "0x16D3F5C", VA = "0x16D3F5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815814", Offset = "0x815814")]
			private set
			{
			}
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x16D3F68", Offset = "0x16D3F68", VA = "0x16D3F68")]
		public Guid Generate()
		{
			return default(Guid);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x16D3FE0", Offset = "0x16D3FE0", VA = "0x16D3FE0")]
		public void Save()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x16D41A0", Offset = "0x16D41A0", VA = "0x16D41A0")]
		public void Load()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x16D4494", Offset = "0x16D4494", VA = "0x16D4494", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x16D44C4", Offset = "0x16D44C4", VA = "0x16D44C4")]
		public string Obtain()
		{
			return null;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x16D4514", Offset = "0x16D4514", VA = "0x16D4514")]
		public AnalogDeviceId()
		{
		}
	}
}
