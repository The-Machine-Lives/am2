using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Com.Uken.PolicyTracker
{
	[Token(Token = "0x2000005")]
	public class PolicySystem : MonoBehaviour
	{
		[Token(Token = "0x2000007")]
		public enum PolicyType
		{
			[Token(Token = "0x400000F")]
			PrivacyPolicy = 0,
			[Token(Token = "0x4000010")]
			TermsOfService = 1
		}

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x18")]
		public bool launchOnEnable;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PolicySystemConfig config;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent OnShow;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent OnAccept;

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x181ACE8", Offset = "0x181ACE8", VA = "0x181ACE8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x181ACF8", Offset = "0x181ACF8", VA = "0x181ACF8")]
		public bool ShowIfRequired()
		{
			return default(bool);
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x181AE70", Offset = "0x181AE70", VA = "0x181AE70")]
		public void AcceptPolicies()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x181AD44", Offset = "0x181AD44", VA = "0x181AD44")]
		public bool ConsentRequired()
		{
			return default(bool);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x181AF0C", Offset = "0x181AF0C", VA = "0x181AF0C")]
		public PolicySystem()
		{
		}
	}
}
