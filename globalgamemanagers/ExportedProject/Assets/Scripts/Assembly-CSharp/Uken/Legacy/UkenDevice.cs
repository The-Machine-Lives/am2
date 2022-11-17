using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Legacy
{
	[Token(Token = "0x20003BE")]
	public class UkenDevice
	{
		[Token(Token = "0x40011DF")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, object> Attributes;

		[Token(Token = "0x40011E0")]
		[FieldOffset(Offset = "0x0")]
		private static string userAgentString;

		[Token(Token = "0x17000566")]
		public static string UserAgentString
		{
			[Token(Token = "0x6001CD4")]
			[Address(RVA = "0xAEB41C", Offset = "0xAEB41C", VA = "0xAEB41C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001CD3")]
		[Address(RVA = "0xAEB414", Offset = "0xAEB414", VA = "0xAEB414")]
		public static string GetAppVersion()
		{
			return null;
		}

		[Token(Token = "0x6001CD5")]
		[Address(RVA = "0xAEBCB8", Offset = "0xAEBCB8", VA = "0xAEBCB8")]
		public UkenDevice()
		{
		}

		[Token(Token = "0x6001CD6")]
		[Address(RVA = "0xAEBFFC", Offset = "0xAEBFFC", VA = "0xAEBFFC")]
		public string UsysDeviceInfoParam()
		{
			return null;
		}

		[Token(Token = "0x6001CD7")]
		[Address(RVA = "0xAEC010", Offset = "0xAEC010", VA = "0xAEC010")]
		public string ToJson()
		{
			return null;
		}

		[Token(Token = "0x6001CD8")]
		[Address(RVA = "0xAEC40C", Offset = "0xAEC40C", VA = "0xAEC40C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6001CD9")]
		[Address(RVA = "0xAEC214", Offset = "0xAEC214", VA = "0xAEC214")]
		private static string Base64Encode(string plainText)
		{
			return null;
		}

		[Token(Token = "0x6001CDA")]
		[Address(RVA = "0xAEBD38", Offset = "0xAEBD38", VA = "0xAEBD38")]
		private void CollectCommonAttributes()
		{
		}

		[Token(Token = "0x6001CDB")]
		[Address(RVA = "0xAEC2B0", Offset = "0xAEC2B0", VA = "0xAEC2B0")]
		private bool IsValidAttribute(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6001CDC")]
		[Address(RVA = "0xAEBE48", Offset = "0xAEBE48", VA = "0xAEBE48")]
		private void CollectPlatformAttributes()
		{
		}
	}
}
