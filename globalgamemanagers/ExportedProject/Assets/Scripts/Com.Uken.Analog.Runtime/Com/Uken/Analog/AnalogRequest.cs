using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Com.Uken.Analog
{
	[Token(Token = "0x200000C")]
	public class AnalogRequest
	{
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x813DF8", Offset = "0x813DF8")]
		private WWW _003CWww_003Ek__BackingField;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x813E08", Offset = "0x813E08")]
		private string _003CRequestId_003Ek__BackingField;

		[Token(Token = "0x1700000D")]
		public WWW Www
		{
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x16D3E78", Offset = "0x16D3E78", VA = "0x16D3E78")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x815824", Offset = "0x815824")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x16D451C", Offset = "0x16D451C", VA = "0x16D451C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x815834", Offset = "0x815834")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public string RequestId
		{
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x16D3508", Offset = "0x16D3508", VA = "0x16D3508")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x815844", Offset = "0x815844")]
			get
			{
				return null;
			}
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x16D45C8", Offset = "0x16D45C8", VA = "0x16D45C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x815854", Offset = "0x815854")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x16D3470", Offset = "0x16D3470", VA = "0x16D3470")]
		public AnalogRequest(string url, byte[] data, Dictionary<string, string> headers)
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x16D4524", Offset = "0x16D4524", VA = "0x16D4524")]
		private void SetRequestId()
		{
		}
	}
}
