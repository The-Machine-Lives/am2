using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.Web
{
	[Token(Token = "0x20003DE")]
	public class UkenRequest
	{
		[Token(Token = "0x20007B1")]
		public delegate void ConfigureRequestParameters(UkenRequest request, ref Dictionary<string, object> parameters);

		[Token(Token = "0x400121A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly char[] SLASH;

		[Token(Token = "0x400121B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool bUseLegacyAuthentication;

		[Token(Token = "0x400121C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string m_Path;

		[Token(Token = "0x400121D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string m_Url;

		[Token(Token = "0x400121E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public byte[] m_PostData;

		[Token(Token = "0x400121F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Dictionary<string, string> m_Headers;

		[Token(Token = "0x4001220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UkenRequestType m_requestType;

		[Token(Token = "0x4001221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static ConfigureRequestParameters CONFIGURE_REQUEST_PARAMETERS;

		[Token(Token = "0x4001222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string m_UknSignaturePath;

		[Token(Token = "0x4001223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string m_UknSignaturePostData;

		[Token(Token = "0x4001224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UkenWWW m_Www;

		[Token(Token = "0x4001225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected Action<bool, UkenRequest> m_onComplete;

		[Token(Token = "0x4001226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_bInternalError;

		[Token(Token = "0x4001227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string wwwText;

		[Token(Token = "0x4001228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string wwwError;

		[Token(Token = "0x4001229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public string m_UserAgentString;

		[Token(Token = "0x400122A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string StubResponseText;

		[Token(Token = "0x1700058A")]
		public string Text
		{
			[Token(Token = "0x6001DD9")]
			[Address(RVA = "0xB425E4", Offset = "0xB425E4", VA = "0xB425E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DDA")]
			[Address(RVA = "0xB42760", Offset = "0xB42760", VA = "0xB42760")]
			set
			{
			}
		}

		[Token(Token = "0x1700058B")]
		public string Error
		{
			[Token(Token = "0x6001DDB")]
			[Address(RVA = "0xB3ED34", Offset = "0xB3ED34", VA = "0xB3ED34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DDC")]
			[Address(RVA = "0xB42798", Offset = "0xB42798", VA = "0xB42798")]
			set
			{
			}
		}

		[Token(Token = "0x1700058C")]
		public Dictionary<string, string> ResponseHeaders
		{
			[Token(Token = "0x6001DDD")]
			[Address(RVA = "0xB427A0", Offset = "0xB427A0", VA = "0xB427A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700058D")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x83C3EC", Offset = "0x83C3EC")]
		public object json
		{
			[Token(Token = "0x6001DDE")]
			[Address(RVA = "0xB3EC64", Offset = "0xB3EC64", VA = "0xB3EC64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001DDF")]
		[Address(RVA = "0xB42850", Offset = "0xB42850", VA = "0xB42850")]
		public UkenRequest(string baseHost, string pathOrUrl, UkenRequestType type = UkenRequestType.GET, [Optional] Dictionary<string, object> parameters, [Optional] string uknKeyPoint, [Optional] string uknUserIdentifier, [Optional] DateTime? uknTimestamp, [Optional] Dictionary<string, string> headers, [Optional] Action<bool, UkenRequest> onComplete)
		{
		}

		[Token(Token = "0x6001DE0")]
		[Address(RVA = "0xB438D0", Offset = "0xB438D0", VA = "0xB438D0")]
		public UkenRequest()
		{
		}

		[Token(Token = "0x6001DE1")]
		[Address(RVA = "0xB43968", Offset = "0xB43968", VA = "0xB43968")]
		public void SetHandler(UkenWWW customWWW)
		{
		}

		[Token(Token = "0x6001DE2")]
		[Address(RVA = "0xB43970", Offset = "0xB43970", VA = "0xB43970")]
		public UkenWWW GetHandler()
		{
			return null;
		}

		[Token(Token = "0x6001DE3")]
		[Address(RVA = "0xB43978", Offset = "0xB43978", VA = "0xB43978")]
		public string GetResponse()
		{
			return null;
		}

		[Token(Token = "0x6001DE4")]
		[Address(RVA = "0xB439B8", Offset = "0xB439B8", VA = "0xB439B8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x838C2C", Offset = "0x838C2C")]
		public void OverrideResponse(string overrideResponse)
		{
		}

		[Token(Token = "0x6001DE5")]
		[Address(RVA = "0xB439C0", Offset = "0xB439C0", VA = "0xB439C0")]
		public UkenRequest Clone()
		{
			return null;
		}

		[Token(Token = "0x6001DE6")]
		[Address(RVA = "0xB43C48", Offset = "0xB43C48", VA = "0xB43C48")]
		public void RequestComplete(bool success)
		{
		}

		[Token(Token = "0x6001DE7")]
		[Address(RVA = "0xB433A8", Offset = "0xB433A8", VA = "0xB433A8")]
		private void ConfigureHeaders(Dictionary<string, string> headers, Dictionary<string, object> parameters)
		{
		}

		[Token(Token = "0x6001DE8")]
		[Address(RVA = "0xB435F4", Offset = "0xB435F4", VA = "0xB435F4")]
		private void AddUknSignatureHeaders(string uknKeyPoint, string uknUserIdentifier, DateTime? uknTimestamp)
		{
		}

		[Token(Token = "0x6001DE9")]
		[Address(RVA = "0xB432DC", Offset = "0xB432DC", VA = "0xB432DC")]
		private void ParseParameters(Dictionary<string, object> parameters)
		{
		}

		[Token(Token = "0x6001DEA")]
		[Address(RVA = "0xB43170", Offset = "0xB43170", VA = "0xB43170")]
		private void ParseAddressParts(string baseHost, string pathOrUrl)
		{
		}

		[Token(Token = "0x6001DEB")]
		[Address(RVA = "0xB44160", Offset = "0xB44160", VA = "0xB44160")]
		public bool HasError()
		{
			return default(bool);
		}

		[Token(Token = "0x6001DEC")]
		[Address(RVA = "0xB43DA0", Offset = "0xB43DA0", VA = "0xB43DA0")]
		private string UknHeader(string uknUserIdentifier, string data)
		{
			return null;
		}

		[Token(Token = "0x6001DED")]
		[Address(RVA = "0xB44004", Offset = "0xB44004", VA = "0xB44004")]
		private bool IsFullUrl(string pathOrUrl)
		{
			return default(bool);
		}

		[Token(Token = "0x6001DEE")]
		[Address(RVA = "0xB44064", Offset = "0xB44064", VA = "0xB44064")]
		private string NormalizeBaseHost(string baseHost)
		{
			return null;
		}

		[Token(Token = "0x6001DEF")]
		[Address(RVA = "0xB44128", Offset = "0xB44128", VA = "0xB44128")]
		private string EnsureRelative(string path)
		{
			return null;
		}

		[Token(Token = "0x6001DF0")]
		[Address(RVA = "0xB43E8C", Offset = "0xB43E8C", VA = "0xB43E8C")]
		public string AddQueryString(string path, Dictionary<string, object> parameters)
		{
			return null;
		}

		[Token(Token = "0x6001DF1")]
		[Address(RVA = "0xB441A0", Offset = "0xB441A0", VA = "0xB441A0")]
		private string QueryString(Dictionary<string, object> parameters)
		{
			return null;
		}

		[Token(Token = "0x6001DF2")]
		[Address(RVA = "0xB43F60", Offset = "0xB43F60", VA = "0xB43F60")]
		private byte[] ToByteArray(string str)
		{
			return null;
		}

		[Token(Token = "0x6001DF3")]
		[Address(RVA = "0xB443A0", Offset = "0xB443A0", VA = "0xB443A0")]
		private string ToString(byte[] byteArray)
		{
			return null;
		}
	}
}
