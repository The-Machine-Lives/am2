using System.Reflection;
using Il2CppDummyDll;

namespace Opencoding.CommandHandlerSystem
{
	[Token(Token = "0x2000006")]
	public class MethodCommandHandler : CommandHandler
	{
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x50")]
		private readonly MethodInfo _methodInfo;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x58")]
		private readonly ParamInfo[] _apparentParameters;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x60")]
		private readonly ParamInfo[] _realParameters;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x68")]
		private readonly ParamInfo[] _paramParameters;

		[Token(Token = "0x17000006")]
		public override ParamInfo[] Parameters
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x17E46F4", Offset = "0x17E46F4", VA = "0x17E46F4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x17E46FC", Offset = "0x17E46FC", VA = "0x17E46FC", Slot = "0")]
		public override bool Equals(object otherObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x17E47B8", Offset = "0x17E47B8", VA = "0x17E47B8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x17E4804", Offset = "0x17E4804", VA = "0x17E4804", Slot = "5")]
		public override void Invoke(params string[] arguments)
		{
		}
	}
}
