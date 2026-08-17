using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	[Token(Token = "0x200011C")]
	[Preserve]
	internal abstract class BsonToken
	{
		[Token(Token = "0x40003FD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FDD8", Offset = "0x80FDD8")]
		private BsonToken _003CParent_003Ek__BackingField;

		[Token(Token = "0x40003FE")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FDE8", Offset = "0x80FDE8")]
		private int _003CCalculatedSize_003Ek__BackingField;

		[Token(Token = "0x170001C8")]
		public abstract BsonType Type
		{
			[Token(Token = "0x60008E4")]
			get;
		}

		[Token(Token = "0x170001C9")]
		public BsonToken Parent
		{
			[Token(Token = "0x60008E5")]
			[Address(RVA = "0xD397D0", Offset = "0xD397D0", VA = "0xD397D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x811794", Offset = "0x811794")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008E6")]
			[Address(RVA = "0xD35288", Offset = "0xD35288", VA = "0xD35288")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8117A4", Offset = "0x8117A4")]
			set
			{
			}
		}

		[Token(Token = "0x170001CA")]
		public int CalculatedSize
		{
			[Token(Token = "0x60008E7")]
			[Address(RVA = "0xD372C8", Offset = "0xD372C8", VA = "0xD372C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8117B4", Offset = "0x8117B4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008E8")]
			[Address(RVA = "0xD37644", Offset = "0xD37644", VA = "0xD37644")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8117C4", Offset = "0x8117C4")]
			set
			{
			}
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0xD353A0", Offset = "0xD353A0", VA = "0xD353A0")]
		protected BsonToken()
		{
		}
	}
}
