using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Uken.Library.Web
{
	[Token(Token = "0x20003E1")]
	public class UkenWWW
	{
		[Token(Token = "0x400123A")]
		[FieldOffset(Offset = "0x10")]
		public WWW Www;

		[Token(Token = "0x400123B")]
		[FieldOffset(Offset = "0x18")]
		private bool isDisposed;

		[Token(Token = "0x400123C")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E338", Offset = "0x82E338")]
		private string _003CrequestID_003Ek__BackingField;

		[Token(Token = "0x400123D")]
		[FieldOffset(Offset = "0x28")]
		private string wwwTextCache;

		[Token(Token = "0x17000594")]
		public string requestID
		{
			[Token(Token = "0x6001E14")]
			[Address(RVA = "0xB444A4", Offset = "0xB444A4", VA = "0xB444A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838DC0", Offset = "0x838DC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E15")]
			[Address(RVA = "0xB444AC", Offset = "0xB444AC", VA = "0xB444AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838DD0", Offset = "0x838DD0")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000595")]
		public string text
		{
			[Token(Token = "0x6001E19")]
			[Address(RVA = "0xB42624", Offset = "0xB42624", VA = "0xB42624")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000596")]
		public Dictionary<string, string> responseHeaders
		{
			[Token(Token = "0x6001E1A")]
			[Address(RVA = "0xB42820", Offset = "0xB42820", VA = "0xB42820")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000597")]
		public bool isDone
		{
			[Token(Token = "0x6001E1B")]
			[Address(RVA = "0xB427F0", Offset = "0xB427F0", VA = "0xB427F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000598")]
		public string error
		{
			[Token(Token = "0x6001E1C")]
			[Address(RVA = "0xB42768", Offset = "0xB42768", VA = "0xB42768")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001E16")]
		[Address(RVA = "0xB444B4", Offset = "0xB444B4", VA = "0xB444B4")]
		public UkenWWW()
		{
		}

		[Token(Token = "0x6001E17")]
		[Address(RVA = "0xB445D4", Offset = "0xB445D4", VA = "0xB445D4")]
		public UkenWWW(string url, byte[] data, Dictionary<string, string> headers)
		{
		}

		[Token(Token = "0x6001E18")]
		[Address(RVA = "0xB44530", Offset = "0xB44530", VA = "0xB44530")]
		private void SetRequestId()
		{
		}

		[Token(Token = "0x6001E1D")]
		[Address(RVA = "0xB4466C", Offset = "0xB4466C", VA = "0xB4466C")]
		public void Dispose()
		{
		}
	}
}
