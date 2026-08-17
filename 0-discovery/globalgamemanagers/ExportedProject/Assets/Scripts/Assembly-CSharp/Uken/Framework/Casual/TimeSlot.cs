using System;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004F6")]
	public class TimeSlot : RuntimeData<RDTimeSlot>
	{
		[Token(Token = "0x400177E")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82FC60", Offset = "0x82FC60")]
		private DateTime _003CstartTimestamp_003Ek__BackingField;

		[Token(Token = "0x400177F")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82FC70", Offset = "0x82FC70")]
		private DateTime _003CendTimestamp_003Ek__BackingField;

		[Token(Token = "0x1700068E")]
		public DateTime startTimestamp
		{
			[Token(Token = "0x6002639")]
			[Address(RVA = "0xA9B604", Offset = "0xA9B604", VA = "0xA9B604")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839FCC", Offset = "0x839FCC")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x600263A")]
			[Address(RVA = "0xA9B60C", Offset = "0xA9B60C", VA = "0xA9B60C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839FDC", Offset = "0x839FDC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700068F")]
		public DateTime endTimestamp
		{
			[Token(Token = "0x600263B")]
			[Address(RVA = "0xA9B614", Offset = "0xA9B614", VA = "0xA9B614")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839FEC", Offset = "0x839FEC")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x600263C")]
			[Address(RVA = "0xA9B61C", Offset = "0xA9B61C", VA = "0xA9B61C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839FFC", Offset = "0x839FFC")]
			private set
			{
			}
		}

		[Token(Token = "0x600263D")]
		[Address(RVA = "0xA9B624", Offset = "0xA9B624", VA = "0xA9B624")]
		public TimeSlot()
		{
		}

		[Token(Token = "0x600263E")]
		[Address(RVA = "0xA9B674", Offset = "0xA9B674", VA = "0xA9B674")]
		public TimeSlot(DateTime inStartTimestamp, DateTime inEndTimestamp)
		{
		}

		[Token(Token = "0x600263F")]
		[Address(RVA = "0xA9B6DC", Offset = "0xA9B6DC", VA = "0xA9B6DC", Slot = "4")]
		public override void Initialize(RDTimeSlot referenceData)
		{
		}

		[Token(Token = "0x6002640")]
		[Address(RVA = "0xA9B758", Offset = "0xA9B758", VA = "0xA9B758")]
		public bool IsActive(DateTime currentTime)
		{
			return default(bool);
		}

		[Token(Token = "0x6002641")]
		[Address(RVA = "0xA9B8A4", Offset = "0xA9B8A4", VA = "0xA9B8A4")]
		private int GetEpochTime(DateTime time)
		{
			return default(int);
		}

		[Token(Token = "0x6002642")]
		[Address(RVA = "0xA9B940", Offset = "0xA9B940", VA = "0xA9B940")]
		public int GetCurrentIteration(DateTime currentTime)
		{
			return default(int);
		}

		[Token(Token = "0x6002643")]
		[Address(RVA = "0xA9B824", Offset = "0xA9B824", VA = "0xA9B824")]
		public bool IsValid()
		{
			return default(bool);
		}
	}
}
