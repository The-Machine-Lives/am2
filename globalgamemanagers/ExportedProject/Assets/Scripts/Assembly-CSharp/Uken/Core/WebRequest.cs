using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Core
{
	[Token(Token = "0x20003D6")]
	public class WebRequest
	{
		[Token(Token = "0x4001208")]
		[FieldOffset(Offset = "0x10")]
		public UkenRequestType sendType;

		[Token(Token = "0x4001209")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, object> m_headers;

		[Token(Token = "0x400120A")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, object> m_parameters;

		[Token(Token = "0x400120B")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E268", Offset = "0x82E268")]
		private Action<WebResponse, WebRequest> _003COnComplete_003Ek__BackingField;

		[Token(Token = "0x400120C")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E278", Offset = "0x82E278")]
		private string _003CendpointUrl_003Ek__BackingField;

		[Token(Token = "0x17000584")]
		public Action<WebResponse, WebRequest> OnComplete
		{
			[Token(Token = "0x6001DA2")]
			[Address(RVA = "0xA1E958", Offset = "0xA1E958", VA = "0xA1E958")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838A78", Offset = "0x838A78")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DA3")]
			[Address(RVA = "0xA1E948", Offset = "0xA1E948", VA = "0xA1E948")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838A88", Offset = "0x838A88")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000585")]
		public string endpointUrl
		{
			[Token(Token = "0x6001DA4")]
			[Address(RVA = "0xA1E960", Offset = "0xA1E960", VA = "0xA1E960")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838A98", Offset = "0x838A98")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DA5")]
			[Address(RVA = "0xA1E950", Offset = "0xA1E950", VA = "0xA1E950")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838AA8", Offset = "0x838AA8")]
			protected set
			{
			}
		}

		[Token(Token = "0x6001DA1")]
		[Address(RVA = "0xA1E898", Offset = "0xA1E898", VA = "0xA1E898")]
		public WebRequest(string url, Action<WebResponse, WebRequest> onComplete)
		{
		}
	}
}
