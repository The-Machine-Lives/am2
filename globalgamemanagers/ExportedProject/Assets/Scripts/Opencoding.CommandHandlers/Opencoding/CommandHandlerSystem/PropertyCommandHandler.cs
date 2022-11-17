using System.Reflection;
using Il2CppDummyDll;

namespace Opencoding.CommandHandlerSystem
{
	[Token(Token = "0x2000009")]
	public class PropertyCommandHandler : CommandHandler
	{
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x50")]
		private readonly MethodInfo _getMethodInfo;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x58")]
		private readonly MethodInfo _setMethodInfo;

		[Token(Token = "0x17000007")]
		public override ParamInfo[] Parameters
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x17E5044", Offset = "0x17E5044", VA = "0x17E5044", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x17E51AC", Offset = "0x17E51AC", VA = "0x17E51AC", Slot = "0")]
		public override bool Equals(object otherObject)
		{
			return default(bool);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x17E5278", Offset = "0x17E5278", VA = "0x17E5278", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x17E52F4", Offset = "0x17E52F4", VA = "0x17E52F4", Slot = "5")]
		public override void Invoke(params string[] arguments)
		{
		}
	}
}
