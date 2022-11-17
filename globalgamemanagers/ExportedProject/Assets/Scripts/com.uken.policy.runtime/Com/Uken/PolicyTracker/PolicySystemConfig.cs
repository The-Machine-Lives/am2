using Il2CppDummyDll;
using UnityEngine;

namespace Com.Uken.PolicyTracker
{
	[Token(Token = "0x2000006")]
	public class PolicySystemConfig : ScriptableObject
	{
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x18")]
		public Policy[] latestPolicies;

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x181AF1C", Offset = "0x181AF1C", VA = "0x181AF1C")]
		public PolicySystemConfig()
		{
		}
	}
}
