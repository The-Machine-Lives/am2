using Il2CppDummyDll;

namespace com.adjust.sdk
{
	[Token(Token = "0x2000222")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x81EA98", Offset = "0x81EA98")]
	internal class JSONLazyCreator : JSONNode
	{
		[Token(Token = "0x4000C0A")]
		[FieldOffset(Offset = "0x10")]
		private JSONNode m_Node;

		[Token(Token = "0x4000C0B")]
		[FieldOffset(Offset = "0x18")]
		private string m_Key;

		[Token(Token = "0x170001F0")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x6000ED1")]
			[Address(RVA = "0x17802F4", Offset = "0x17802F4", VA = "0x17802F4", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000ED2")]
			[Address(RVA = "0x1780358", Offset = "0x1780358", VA = "0x1780358", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x170001F1")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x6000ED3")]
			[Address(RVA = "0x17803E4", Offset = "0x17803E4", VA = "0x17803E4", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000ED4")]
			[Address(RVA = "0x1780454", Offset = "0x1780454", VA = "0x1780454", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x170001F2")]
		public override int AsInt
		{
			[Token(Token = "0x6000EDD")]
			[Address(RVA = "0x17806F0", Offset = "0x17806F0", VA = "0x17806F0", Slot = "18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000EDE")]
			[Address(RVA = "0x1780774", Offset = "0x1780774", VA = "0x1780774", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x170001F3")]
		public override float AsFloat
		{
			[Token(Token = "0x6000EDF")]
			[Address(RVA = "0x17807FC", Offset = "0x17807FC", VA = "0x17807FC", Slot = "20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000EE0")]
			[Address(RVA = "0x1780880", Offset = "0x1780880", VA = "0x1780880", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x170001F4")]
		public override double AsDouble
		{
			[Token(Token = "0x6000EE1")]
			[Address(RVA = "0x1780908", Offset = "0x1780908", VA = "0x1780908", Slot = "22")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000EE2")]
			[Address(RVA = "0x178098C", Offset = "0x178098C", VA = "0x178098C", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x170001F5")]
		public override bool AsBool
		{
			[Token(Token = "0x6000EE3")]
			[Address(RVA = "0x1780A14", Offset = "0x1780A14", VA = "0x1780A14", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000EE4")]
			[Address(RVA = "0x1780A98", Offset = "0x1780A98", VA = "0x1780A98", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x170001F6")]
		public override JSONArray AsArray
		{
			[Token(Token = "0x6000EE5")]
			[Address(RVA = "0x1780B20", Offset = "0x1780B20", VA = "0x1780B20", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F7")]
		public override JSONClass AsObject
		{
			[Token(Token = "0x6000EE6")]
			[Address(RVA = "0x1780B88", Offset = "0x1780B88", VA = "0x1780B88", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000ECE")]
		[Address(RVA = "0x177D110", Offset = "0x177D110", VA = "0x177D110")]
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		[Token(Token = "0x6000ECF")]
		[Address(RVA = "0x177E1DC", Offset = "0x177E1DC", VA = "0x177E1DC")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		[Token(Token = "0x6000ED0")]
		[Address(RVA = "0x1780278", Offset = "0x1780278", VA = "0x1780278")]
		private void Set(JSONNode aVal)
		{
		}

		[Token(Token = "0x6000ED5")]
		[Address(RVA = "0x17804E8", Offset = "0x17804E8", VA = "0x17804E8", Slot = "12")]
		public override void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6000ED6")]
		[Address(RVA = "0x1780574", Offset = "0x1780574", VA = "0x1780574", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000ED7")]
		[Address(RVA = "0x1780608", Offset = "0x1780608", VA = "0x1780608")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000ED8")]
		[Address(RVA = "0x1780620", Offset = "0x1780620", VA = "0x1780620")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000ED9")]
		[Address(RVA = "0x1780638", Offset = "0x1780638", VA = "0x1780638", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000EDA")]
		[Address(RVA = "0x1780650", Offset = "0x1780650", VA = "0x1780650", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000EDB")]
		[Address(RVA = "0x1780660", Offset = "0x1780660", VA = "0x1780660", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000EDC")]
		[Address(RVA = "0x17806A8", Offset = "0x17806A8", VA = "0x17806A8", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}
	}
}
