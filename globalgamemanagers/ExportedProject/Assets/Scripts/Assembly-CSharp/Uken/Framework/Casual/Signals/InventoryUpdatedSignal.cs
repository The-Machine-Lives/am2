using Il2CppDummyDll;

namespace Uken.Framework.Casual.Signals
{
	[Token(Token = "0x2000587")]
	public class InventoryUpdatedSignal : Signal
	{
		[Token(Token = "0x4001A47")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832BC0", Offset = "0x832BC0")]
		private string _003Cm_itemName_003Ek__BackingField;

		[Token(Token = "0x4001A48")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832BD0", Offset = "0x832BD0")]
		private long _003Cm_currentQuantity_003Ek__BackingField;

		[Token(Token = "0x4001A49")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832BE0", Offset = "0x832BE0")]
		private long _003Cm_previousQuantity_003Ek__BackingField;

		[Token(Token = "0x17000768")]
		public string m_itemName
		{
			[Token(Token = "0x6002A5D")]
			[Address(RVA = "0xA91D38", Offset = "0xA91D38", VA = "0xA91D38")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A7AC", Offset = "0x83A7AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A5E")]
			[Address(RVA = "0xA91D40", Offset = "0xA91D40", VA = "0xA91D40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A7BC", Offset = "0x83A7BC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000769")]
		public long m_currentQuantity
		{
			[Token(Token = "0x6002A5F")]
			[Address(RVA = "0xA91D48", Offset = "0xA91D48", VA = "0xA91D48")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A7CC", Offset = "0x83A7CC")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6002A60")]
			[Address(RVA = "0xA91D50", Offset = "0xA91D50", VA = "0xA91D50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A7DC", Offset = "0x83A7DC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700076A")]
		public long m_previousQuantity
		{
			[Token(Token = "0x6002A61")]
			[Address(RVA = "0xA91D58", Offset = "0xA91D58", VA = "0xA91D58")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A7EC", Offset = "0x83A7EC")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6002A62")]
			[Address(RVA = "0xA91D60", Offset = "0xA91D60", VA = "0xA91D60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A7FC", Offset = "0x83A7FC")]
			private set
			{
			}
		}

		[Token(Token = "0x6002A63")]
		[Address(RVA = "0xA91D68", Offset = "0xA91D68", VA = "0xA91D68")]
		public InventoryUpdatedSignal(string itemName, long currentQuantity, long previousQuantity)
		{
		}
	}
}
