using System;
using Il2CppDummyDll;

namespace Com.Uken.PolicyTracker
{
	[Serializable]
	[Token(Token = "0x2000003")]
	public class Policy
	{
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x10")]
		public PolicySystem.PolicyType policyType;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x18")]
		public string version;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x20")]
		public string url;

		[Token(Token = "0x17000001")]
		public Version Version
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x181AAF0", Offset = "0x181AAF0", VA = "0x181AAF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x181AAB4", Offset = "0x181AAB4", VA = "0x181AAB4")]
		public Policy(PolicySystem.PolicyType t, string v)
		{
		}
	}
}
