using System.Collections.Generic;
using Il2CppDummyDll;

namespace Facebook.Unity
{
	[Token(Token = "0x200004B")]
	internal class ResultContainer
	{
		[Token(Token = "0x400006F")]
		private const string CanvasResponseKey = "response";

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8164A0", Offset = "0x8164A0")]
		private string _003CRawResult_003Ek__BackingField;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8164B0", Offset = "0x8164B0")]
		private IDictionary<string, object> _003CResultDictionary_003Ek__BackingField;

		[Token(Token = "0x1700005E")]
		public string RawResult
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x17C2E2C", Offset = "0x17C2E2C", VA = "0x17C2E2C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816CE0", Offset = "0x816CE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x17C2EE8", Offset = "0x17C2EE8", VA = "0x17C2EE8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816CF0", Offset = "0x816CF0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public IDictionary<string, object> ResultDictionary
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x17C27C4", Offset = "0x17C27C4", VA = "0x17C27C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816D00", Offset = "0x816D00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x17C2EF0", Offset = "0x17C2EF0", VA = "0x17C2EF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816D10", Offset = "0x816D10")]
			set
			{
			}
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x17C2E34", Offset = "0x17C2E34", VA = "0x17C2E34")]
		public ResultContainer(IDictionary<string, object> dictionary)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x17BEA38", Offset = "0x17BEA38", VA = "0x17BEA38")]
		public ResultContainer(string result)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x17C2EF8", Offset = "0x17C2EF8", VA = "0x17C2EF8")]
		private IDictionary<string, object> GetWebFormattedResponseDictionary(IDictionary<string, object> resultDictionary)
		{
			return null;
		}
	}
}
