using Il2CppDummyDll;

namespace Uken.Framework.Casual.Signals
{
	[Token(Token = "0x2000583")]
	public class AddedToCollectionSignal : Signal
	{
		[Token(Token = "0x4001A3C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832B10", Offset = "0x832B10")]
		private string _003Cm_collectionAddedTo_003Ek__BackingField;

		[Token(Token = "0x4001A3D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832B20", Offset = "0x832B20")]
		private long _003Cm_amountAdded_003Ek__BackingField;

		[Token(Token = "0x1700075D")]
		public string m_collectionAddedTo
		{
			[Token(Token = "0x6002A43")]
			[Address(RVA = "0xA91C08", Offset = "0xA91C08", VA = "0xA91C08")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A64C", Offset = "0x83A64C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A44")]
			[Address(RVA = "0xA91C10", Offset = "0xA91C10", VA = "0xA91C10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A65C", Offset = "0x83A65C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700075E")]
		public long m_amountAdded
		{
			[Token(Token = "0x6002A45")]
			[Address(RVA = "0xA91C18", Offset = "0xA91C18", VA = "0xA91C18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A66C", Offset = "0x83A66C")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6002A46")]
			[Address(RVA = "0xA91C20", Offset = "0xA91C20", VA = "0xA91C20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A67C", Offset = "0x83A67C")]
			private set
			{
			}
		}

		[Token(Token = "0x6002A47")]
		[Address(RVA = "0xA91C28", Offset = "0xA91C28", VA = "0xA91C28")]
		public AddedToCollectionSignal(string collectionAddedTo, long amountAdded)
		{
		}
	}
}
