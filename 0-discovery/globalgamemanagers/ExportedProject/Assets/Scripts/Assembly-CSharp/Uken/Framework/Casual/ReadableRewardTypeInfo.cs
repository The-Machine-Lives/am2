using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004B9")]
	[IsReadOnly]
	public struct ReadableRewardTypeInfo
	{
		[Token(Token = "0x4001618")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EAFC", Offset = "0x82EAFC")]
		private readonly string _003CreadableRewardType_003Ek__BackingField;

		[Token(Token = "0x4001619")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EB0C", Offset = "0x82EB0C")]
		private readonly bool _003CshowAmount_003Ek__BackingField;

		[Token(Token = "0x170005FD")]
		public string readableRewardType
		{
			[Token(Token = "0x6002394")]
			[Address(RVA = "0x89BE28", Offset = "0x89BE28", VA = "0x89BE28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83968C", Offset = "0x83968C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005FE")]
		public bool showAmount
		{
			[Token(Token = "0x6002395")]
			[Address(RVA = "0x89BE30", Offset = "0x89BE30", VA = "0x89BE30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83969C", Offset = "0x83969C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6002396")]
		[Address(RVA = "0x89BE38", Offset = "0x89BE38", VA = "0x89BE38")]
		public ReadableRewardTypeInfo(string inReadableRewardType, bool inShowAmount)
		{
		}
	}
}
