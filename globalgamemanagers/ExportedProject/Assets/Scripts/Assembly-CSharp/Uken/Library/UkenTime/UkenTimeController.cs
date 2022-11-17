using System;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Library.Web;

namespace Uken.Library.UkenTime
{
	[Token(Token = "0x20003E5")]
	public class UkenTimeController : UkenController
	{
		[Token(Token = "0x4001256")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DateTime Epoch;

		[Token(Token = "0x4001257")]
		[FieldOffset(Offset = "0x18")]
		private double serverSyncTime;

		[Token(Token = "0x4001258")]
		[FieldOffset(Offset = "0x20")]
		private float querySentTime;

		[Token(Token = "0x4001259")]
		[FieldOffset(Offset = "0x28")]
		public DateTime lastPauseDate;

		[Token(Token = "0x400125A")]
		[FieldOffset(Offset = "0x30")]
		public float minPauseTimeToQuery;

		[Token(Token = "0x6001E2C")]
		[Address(RVA = "0xB3E6A4", Offset = "0xB3E6A4", VA = "0xB3E6A4")]
		public void Configure(float aQuerySentTime, float queryReceivedTime, double serverTime)
		{
		}

		[Token(Token = "0x6001E2D")]
		[Address(RVA = "0xB3E6F4", Offset = "0xB3E6F4", VA = "0xB3E6F4")]
		public void PingServerForTime(string serverTimeURL)
		{
		}

		[Token(Token = "0x6001E2E")]
		[Address(RVA = "0xB3EA68", Offset = "0xB3EA68", VA = "0xB3EA68")]
		private void PingServerOnComplete(bool success, UkenRequest request)
		{
		}

		[Token(Token = "0x6001E2F")]
		[Address(RVA = "0xB3ED74", Offset = "0xB3ED74", VA = "0xB3ED74")]
		public bool IsTimeAccurate()
		{
			return default(bool);
		}

		[Token(Token = "0x6001E30")]
		[Address(RVA = "0xB3ED84", Offset = "0xB3ED84", VA = "0xB3ED84")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x838E18", Offset = "0x838E18")]
		public DateTime UtcNow()
		{
			return default(DateTime);
		}

		[Token(Token = "0x6001E31")]
		[Address(RVA = "0xB319A4", Offset = "0xB319A4", VA = "0xB319A4")]
		public double CurrentUnixTime()
		{
			return default(double);
		}

		[Token(Token = "0x6001E32")]
		[Address(RVA = "0xB3EE2C", Offset = "0xB3EE2C", VA = "0xB3EE2C")]
		public DateTime SafeDateTimeParse(string time, DateTime fallback)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6001E33")]
		[Address(RVA = "0xB3ED98", Offset = "0xB3ED98", VA = "0xB3ED98")]
		public DateTime UnixTimeToDateTime(double seconds)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6001E34")]
		[Address(RVA = "0xB3EFD8", Offset = "0xB3EFD8", VA = "0xB3EFD8")]
		public int DateTimeToUnixTime(DateTime dt)
		{
			return default(int);
		}

		[Token(Token = "0x6001E35")]
		[Address(RVA = "0xB3F0F0", Offset = "0xB3F0F0", VA = "0xB3F0F0")]
		public UkenTimeController()
		{
		}
	}
}
