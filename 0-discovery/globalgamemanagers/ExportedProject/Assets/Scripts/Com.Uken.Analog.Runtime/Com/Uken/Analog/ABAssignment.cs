using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000015")]
	public class ABAssignment : BaseEvent
	{
		[Token(Token = "0x4000053")]
		private const string TYPE = "ab_test";

		[Token(Token = "0x4000054")]
		private const string NAME = "assignment";

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x16CD790", Offset = "0x16CD790", VA = "0x16CD790")]
		public ABAssignment(List<Assignment> assignments)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x16CD8F4", Offset = "0x16CD8F4", VA = "0x16CD8F4")]
		public ABAssignment(Assignment assignment)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x16CD998", Offset = "0x16CD998", VA = "0x16CD998", Slot = "5")]
		public override bool ValidateChild()
		{
			return default(bool);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x16CD828", Offset = "0x16CD828", VA = "0x16CD828")]
		private void Construct(List<Assignment> assignments)
		{
		}
	}
}
