using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000554")]
	public class UserProfileField
	{
		[Token(Token = "0x400196C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8326E0", Offset = "0x8326E0")]
		private string _003CDisplayName_003Ek__BackingField;

		[Token(Token = "0x400196D")]
		[FieldOffset(Offset = "0x18")]
		private RDUserProfileField m_fieldData;

		[Token(Token = "0x400196E")]
		[FieldOffset(Offset = "0x20")]
		private ItemController m_itemController;

		[Token(Token = "0x17000732")]
		public string Reference
		{
			[Token(Token = "0x60028D5")]
			[Address(RVA = "0xA9C80C", Offset = "0xA9C80C", VA = "0xA9C80C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000733")]
		public string FieldName
		{
			[Token(Token = "0x60028D6")]
			[Address(RVA = "0xA9C838", Offset = "0xA9C838", VA = "0xA9C838")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000734")]
		public string ViewData
		{
			[Token(Token = "0x60028D7")]
			[Address(RVA = "0xA9C864", Offset = "0xA9C864", VA = "0xA9C864")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000735")]
		public bool IsVisible
		{
			[Token(Token = "0x60028D8")]
			[Address(RVA = "0xA9C890", Offset = "0xA9C890", VA = "0xA9C890")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000736")]
		public int DisplayOrder
		{
			[Token(Token = "0x60028D9")]
			[Address(RVA = "0xA9C8BC", Offset = "0xA9C8BC", VA = "0xA9C8BC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000737")]
		public string DisplayName
		{
			[Token(Token = "0x60028DA")]
			[Address(RVA = "0xA9C8E8", Offset = "0xA9C8E8", VA = "0xA9C8E8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A3F8", Offset = "0x83A3F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60028DB")]
			[Address(RVA = "0xA9C8F0", Offset = "0xA9C8F0", VA = "0xA9C8F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A408", Offset = "0x83A408")]
			private set
			{
			}
		}

		[Token(Token = "0x17000738")]
		public string FallbackText
		{
			[Token(Token = "0x60028DC")]
			[Address(RVA = "0xA9C8F8", Offset = "0xA9C8F8", VA = "0xA9C8F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000739")]
		private ItemView m_itemView
		{
			[Token(Token = "0x60028DD")]
			[Address(RVA = "0xA9C924", Offset = "0xA9C924", VA = "0xA9C924")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60028DE")]
		[Address(RVA = "0xA9C968", Offset = "0xA9C968", VA = "0xA9C968")]
		public UserProfileField(RDUserProfileField fieldData, string displayName, ItemController itemController)
		{
		}
	}
}
