using Il2CppDummyDll;

namespace Uken.Core
{
	[Token(Token = "0x20003D5")]
	public class WebResponse
	{
		[Token(Token = "0x4001205")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E238", Offset = "0x82E238")]
		private bool _003CSuccess_003Ek__BackingField;

		[Token(Token = "0x4001206")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E248", Offset = "0x82E248")]
		private string _003CResponseText_003Ek__BackingField;

		[Token(Token = "0x4001207")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E258", Offset = "0x82E258")]
		private UkenErrorData _003CErrorData_003Ek__BackingField;

		[Token(Token = "0x17000581")]
		public bool Success
		{
			[Token(Token = "0x6001D98")]
			[Address(RVA = "0xA1E968", Offset = "0xA1E968", VA = "0xA1E968")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838A18", Offset = "0x838A18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001D99")]
			[Address(RVA = "0xA1E970", Offset = "0xA1E970", VA = "0xA1E970")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838A28", Offset = "0x838A28")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000582")]
		public string ResponseText
		{
			[Token(Token = "0x6001D9A")]
			[Address(RVA = "0xA1E97C", Offset = "0xA1E97C", VA = "0xA1E97C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838A38", Offset = "0x838A38")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D9B")]
			[Address(RVA = "0xA1E984", Offset = "0xA1E984", VA = "0xA1E984")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838A48", Offset = "0x838A48")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000583")]
		public UkenErrorData ErrorData
		{
			[Token(Token = "0x6001D9C")]
			[Address(RVA = "0xA1E98C", Offset = "0xA1E98C", VA = "0xA1E98C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838A58", Offset = "0x838A58")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D9D")]
			[Address(RVA = "0xA1E994", Offset = "0xA1E994", VA = "0xA1E994")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838A68", Offset = "0x838A68")]
			protected set
			{
			}
		}

		[Token(Token = "0x6001D9E")]
		[Address(RVA = "0xA1E99C", Offset = "0xA1E99C", VA = "0xA1E99C")]
		public WebResponse(bool success, string responseText)
		{
		}

		[Token(Token = "0x6001D9F")]
		[Address(RVA = "0xA1EA40", Offset = "0xA1EA40", VA = "0xA1EA40")]
		public string GetError()
		{
			return null;
		}

		[Token(Token = "0x6001DA0")]
		[Address(RVA = "0xA1EA9C", Offset = "0xA1EA9C", VA = "0xA1EA9C")]
		public int GetUkenErrorCode()
		{
			return default(int);
		}
	}
}
