using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.Metrics
{
	[Serializable]
	[Token(Token = "0x2000415")]
	public class MetricsPayload
	{
		[Token(Token = "0x40012F9")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E418", Offset = "0x82E418")]
		private List<GaugeMetric> _003Cgauge_list_003Ek__BackingField;

		[Token(Token = "0x40012FA")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E428", Offset = "0x82E428")]
		private List<CounterMetric> _003Ccounter_list_003Ek__BackingField;

		[Token(Token = "0x170005A1")]
		public List<GaugeMetric> gauge_list
		{
			[Token(Token = "0x6001EF9")]
			[Address(RVA = "0xBAC318", Offset = "0xBAC318", VA = "0xBAC318")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838FC4", Offset = "0x838FC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EFA")]
			[Address(RVA = "0xBAC320", Offset = "0xBAC320", VA = "0xBAC320")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838FD4", Offset = "0x838FD4")]
			private set
			{
			}
		}

		[Token(Token = "0x170005A2")]
		public List<CounterMetric> counter_list
		{
			[Token(Token = "0x6001EFB")]
			[Address(RVA = "0xBAC328", Offset = "0xBAC328", VA = "0xBAC328")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838FE4", Offset = "0x838FE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EFC")]
			[Address(RVA = "0xBAC330", Offset = "0xBAC330", VA = "0xBAC330")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838FF4", Offset = "0x838FF4")]
			private set
			{
			}
		}

		[Token(Token = "0x6001EFD")]
		[Address(RVA = "0xBAB824", Offset = "0xBAB824", VA = "0xBAB824")]
		public MetricsPayload()
		{
		}

		[Token(Token = "0x6001EFE")]
		[Address(RVA = "0xBABA44", Offset = "0xBABA44", VA = "0xBABA44")]
		public void AddCounter(string name, int delta)
		{
		}

		[Token(Token = "0x6001EFF")]
		[Address(RVA = "0xBABBFC", Offset = "0xBABBFC", VA = "0xBABBFC")]
		public void AddGauge(string name, int value)
		{
		}

		[Token(Token = "0x6001F00")]
		[Address(RVA = "0xBABD18", Offset = "0xBABD18", VA = "0xBABD18")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		[Token(Token = "0x6001F01")]
		[Address(RVA = "0xBABF24", Offset = "0xBABF24", VA = "0xBABF24")]
		public void Merge(MetricsPayload metricsPayload)
		{
		}
	}
}
