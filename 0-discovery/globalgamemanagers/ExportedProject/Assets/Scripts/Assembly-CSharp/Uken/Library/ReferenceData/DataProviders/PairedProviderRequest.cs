using System;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.ReferenceData.DataProviders
{
	[Token(Token = "0x2000482")]
	public class PairedProviderRequest
	{
		[Token(Token = "0x40014A6")]
		[FieldOffset(Offset = "0x10")]
		public ChecksumRequest checksumRequest;

		[Token(Token = "0x40014A7")]
		[FieldOffset(Offset = "0x18")]
		public NetworkProviderRequest providerRequest;

		[Token(Token = "0x40014A8")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E9FC", Offset = "0x82E9FC")]
		private string _003Cm_checksum_003Ek__BackingField;

		[Token(Token = "0x40014A9")]
		[FieldOffset(Offset = "0x28")]
		public Action<string> m_onChecksumRequestComplete;

		[Token(Token = "0x40014AA")]
		[FieldOffset(Offset = "0x30")]
		public Action<WebResponse, WebRequest> m_onPairedRequestComplete;

		[Token(Token = "0x170005D9")]
		public string m_checksum
		{
			[Token(Token = "0x6002130")]
			[Address(RVA = "0xB36E70", Offset = "0xB36E70", VA = "0xB36E70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8394A4", Offset = "0x8394A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002131")]
			[Address(RVA = "0xB371E4", Offset = "0xB371E4", VA = "0xB371E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8394B4", Offset = "0x8394B4")]
			private set
			{
			}
		}

		[Token(Token = "0x6002132")]
		[Address(RVA = "0xB371EC", Offset = "0xB371EC", VA = "0xB371EC")]
		public void OnChecksumQueryComplete(WebResponse response, WebRequest request)
		{
		}

		[Token(Token = "0x6002133")]
		[Address(RVA = "0xB3716C", Offset = "0xB3716C", VA = "0xB3716C")]
		public void OnProviderQueryComplete(WebResponse response, WebRequest request)
		{
		}

		[Token(Token = "0x6002134")]
		[Address(RVA = "0xB35AB0", Offset = "0xB35AB0", VA = "0xB35AB0")]
		public PairedProviderRequest()
		{
		}
	}
}
