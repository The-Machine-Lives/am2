using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000555")]
	public class UserProfileFields : DepotController
	{
		[Token(Token = "0x400196F")]
		[FieldOffset(Offset = "0x20")]
		protected Localizations m_localizations;

		[Token(Token = "0x4001970")]
		[FieldOffset(Offset = "0x28")]
		protected ItemController m_items;

		[Token(Token = "0x1700073A")]
		protected DepotEntity<RDUserProfileField> m_fields
		{
			[Token(Token = "0x60028DF")]
			[Address(RVA = "0xA9C9A8", Offset = "0xA9C9A8", VA = "0xA9C9A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60028E0")]
		[Address(RVA = "0xA9CB10", Offset = "0xA9CB10", VA = "0xA9CB10")]
		public UserProfileFields(DataStoreController controller)
		{
		}

		[Token(Token = "0x60028E1")]
		[Address(RVA = "0xA9CB18", Offset = "0xA9CB18", VA = "0xA9CB18", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60028E2")]
		[Address(RVA = "0xA9CB84", Offset = "0xA9CB84", VA = "0xA9CB84")]
		public List<UserProfileField> GetFields()
		{
			return null;
		}

		[Token(Token = "0x60028E3")]
		[Address(RVA = "0xA9CDB4", Offset = "0xA9CDB4", VA = "0xA9CDB4")]
		public Dictionary<string, UserProfileField> GetFieldMap()
		{
			return null;
		}

		[Token(Token = "0x60028E4")]
		[Address(RVA = "0xA9CF5C", Offset = "0xA9CF5C", VA = "0xA9CF5C")]
		public bool IsReady()
		{
			return default(bool);
		}
	}
}
