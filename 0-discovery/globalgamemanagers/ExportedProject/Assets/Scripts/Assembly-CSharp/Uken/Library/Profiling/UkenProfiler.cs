using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Uken.Library.Profiling
{
	[Token(Token = "0x20003FE")]
	public class UkenProfiler
	{
		[Token(Token = "0x40012B1")]
		[FieldOffset(Offset = "0x10")]
		private object profilerLockObject;

		[Token(Token = "0x40012B2")]
		[FieldOffset(Offset = "0x18")]
		public LogType logAsLevel;

		[Token(Token = "0x40012B3")]
		[FieldOffset(Offset = "0x1C")]
		public bool EnableProfiling;

		[Token(Token = "0x40012B4")]
		[FieldOffset(Offset = "0x1D")]
		public bool EnableCallStackReporting;

		[Token(Token = "0x40012B5")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, UkenProfilerData> profileData;

		[Token(Token = "0x40012B6")]
		[FieldOffset(Offset = "0x0")]
		private static UkenProfiler _self;

		[Token(Token = "0x6001E76")]
		[Address(RVA = "0xB32520", Offset = "0xB32520", VA = "0xB32520")]
		private static UkenProfiler Get()
		{
			return null;
		}

		[Token(Token = "0x6001E77")]
		[Address(RVA = "0xB32588", Offset = "0xB32588", VA = "0xB32588")]
		public static void Start(string name)
		{
		}

		[Token(Token = "0x6001E78")]
		[Address(RVA = "0xB3281C", Offset = "0xB3281C", VA = "0xB3281C")]
		public static float Stop(string name)
		{
			return default(float);
		}

		[Token(Token = "0x6001E79")]
		[Address(RVA = "0xB32ADC", Offset = "0xB32ADC", VA = "0xB32ADC")]
		public static void Flush()
		{
		}

		[Token(Token = "0x6001E7A")]
		[Address(RVA = "0xB32C3C", Offset = "0xB32C3C", VA = "0xB32C3C")]
		public UkenProfiler()
		{
		}

		[Token(Token = "0x6001E7B")]
		[Address(RVA = "0xB32CE4", Offset = "0xB32CE4", VA = "0xB32CE4")]
		private bool Initialize()
		{
			return default(bool);
		}

		[Token(Token = "0x6001E7C")]
		[Address(RVA = "0xB32600", Offset = "0xB32600", VA = "0xB32600")]
		public void StartTimer(string name)
		{
		}

		[Token(Token = "0x6001E7D")]
		[Address(RVA = "0xB32898", Offset = "0xB32898", VA = "0xB32898")]
		public float StopTimer(string name)
		{
			return default(float);
		}

		[Token(Token = "0x6001E7E")]
		[Address(RVA = "0xB32DE8", Offset = "0xB32DE8", VA = "0xB32DE8")]
		private void Report(string name, bool isStarting)
		{
		}

		[Token(Token = "0x6001E7F")]
		[Address(RVA = "0xB32B4C", Offset = "0xB32B4C", VA = "0xB32B4C")]
		public void FlushProfileLogs()
		{
		}
	}
}
