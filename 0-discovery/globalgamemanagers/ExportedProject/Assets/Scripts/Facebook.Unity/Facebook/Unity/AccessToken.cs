using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Facebook.Unity
{
	[Token(Token = "0x2000006")]
	public class AccessToken
	{
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816170", Offset = "0x816170")]
		private static AccessToken _003CCurrentAccessToken_003Ek__BackingField;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816180", Offset = "0x816180")]
		private string _003CTokenString_003Ek__BackingField;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816190", Offset = "0x816190")]
		private DateTime _003CExpirationTime_003Ek__BackingField;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8161A0", Offset = "0x8161A0")]
		private IEnumerable<string> _003CPermissions_003Ek__BackingField;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8161B0", Offset = "0x8161B0")]
		private string _003CUserId_003Ek__BackingField;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8161C0", Offset = "0x8161C0")]
		private DateTime? _003CLastRefresh_003Ek__BackingField;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8161D0", Offset = "0x8161D0")]
		private string _003CGraphDomain_003Ek__BackingField;

		[Token(Token = "0x17000005")]
		public static AccessToken CurrentAccessToken
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0xCC7894", Offset = "0xCC7894", VA = "0xCC7894")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8166B0", Offset = "0x8166B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600001B")]
			[Address(RVA = "0xCC78E4", Offset = "0xCC78E4", VA = "0xCC78E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8166C0", Offset = "0x8166C0")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public string TokenString
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0xCC7938", Offset = "0xCC7938", VA = "0xCC7938")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8166D0", Offset = "0x8166D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600001D")]
			[Address(RVA = "0xCC7864", Offset = "0xCC7864", VA = "0xCC7864")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8166E0", Offset = "0x8166E0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public DateTime ExpirationTime
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0xCC7940", Offset = "0xCC7940", VA = "0xCC7940")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8166F0", Offset = "0x8166F0")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x600001F")]
			[Address(RVA = "0xCC786C", Offset = "0xCC786C", VA = "0xCC786C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816700", Offset = "0x816700")]
			private set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public IEnumerable<string> Permissions
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0xCC7948", Offset = "0xCC7948", VA = "0xCC7948")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816710", Offset = "0x816710")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000021")]
			[Address(RVA = "0xCC7874", Offset = "0xCC7874", VA = "0xCC7874")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816720", Offset = "0x816720")]
			private set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public string UserId
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0xCC7950", Offset = "0xCC7950", VA = "0xCC7950")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816730", Offset = "0x816730")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000023")]
			[Address(RVA = "0xCC787C", Offset = "0xCC787C", VA = "0xCC787C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816740", Offset = "0x816740")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public DateTime? LastRefresh
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0xCC7958", Offset = "0xCC7958", VA = "0xCC7958")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816750", Offset = "0x816750")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000025")]
			[Address(RVA = "0xCC7884", Offset = "0xCC7884", VA = "0xCC7884")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816760", Offset = "0x816760")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public string GraphDomain
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0xCC7964", Offset = "0xCC7964", VA = "0xCC7964")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816770", Offset = "0x816770")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000027")]
			[Address(RVA = "0xCC788C", Offset = "0xCC788C", VA = "0xCC788C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816780", Offset = "0x816780")]
			private set
			{
			}
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xCC76C4", Offset = "0xCC76C4", VA = "0xCC76C4")]
		internal AccessToken(string tokenString, string userId, DateTime expirationTime, IEnumerable<string> permissions, DateTime? lastRefresh, string graphDomain)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xCC796C", Offset = "0xCC796C", VA = "0xCC796C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xCC7B6C", Offset = "0xCC7B6C", VA = "0xCC7B6C")]
		internal string ToJson()
		{
			return null;
		}
	}
}
