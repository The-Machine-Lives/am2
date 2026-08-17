using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000500")]
	public class RuntimeItem
	{
		[Token(Token = "0x4001796")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82FD78", Offset = "0x82FD78")]
		private string _003Creference_003Ek__BackingField;

		[Token(Token = "0x17000693")]
		public string reference
		{
			[Token(Token = "0x600265B")]
			[Address(RVA = "0xA8C820", Offset = "0xA8C820", VA = "0xA8C820")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A01C", Offset = "0x83A01C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600265C")]
			[Address(RVA = "0xA8C828", Offset = "0xA8C828", VA = "0xA8C828")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A02C", Offset = "0x83A02C")]
			private set
			{
			}
		}

		[Token(Token = "0x600265D")]
		[Address(RVA = "0xA8C830", Offset = "0xA8C830", VA = "0xA8C830")]
		public RuntimeItem(string reference)
		{
		}

		[Token(Token = "0x600265E")]
		[Address(RVA = "0xA8C85C", Offset = "0xA8C85C", VA = "0xA8C85C")]
		public RuntimeItem(BaseEntityDocument entity)
		{
		}

		[Token(Token = "0x600265F")]
		[Address(RVA = "0xA8C898", Offset = "0xA8C898", VA = "0xA8C898", Slot = "4")]
		public virtual Dictionary<string, long> GetFinalRewards(long quantity)
		{
			return null;
		}

		[Token(Token = "0x6002660")]
		[Address(RVA = "0xA8C938", Offset = "0xA8C938", VA = "0xA8C938", Slot = "5")]
		public virtual bool IsLevelledItem()
		{
			return default(bool);
		}

		[Token(Token = "0x6002661")]
		[Address(RVA = "0xA8C940", Offset = "0xA8C940", VA = "0xA8C940", Slot = "6")]
		public virtual void GetLevelDelta(long quantityDelta, bool isPostTransaction, out ItemLevelState beforeState, out ItemLevelState afterState)
		{
		}
	}
}
