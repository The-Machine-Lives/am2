using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Com.Uken.PolicyTracker
{
	[Token(Token = "0x2000004")]
	public class PolicyConsentView : MonoBehaviour
	{
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x18")]
		public UnityEvent OnConsent;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x20")]
		private string privacyUrl;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x28")]
		private string tosUrl;

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x181AB58", Offset = "0x181AB58", VA = "0x181AB58")]
		public void LoadPolicies(Policy[] policies)
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x181AC38", Offset = "0x181AC38", VA = "0x181AC38")]
		public void PrivacyPolicyClicked()
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x181AC44", Offset = "0x181AC44", VA = "0x181AC44")]
		public void TosClicked()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x181AC50", Offset = "0x181AC50", VA = "0x181AC50")]
		public void ConsentClicked()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x181AC80", Offset = "0x181AC80", VA = "0x181AC80")]
		public PolicyConsentView()
		{
		}
	}
}
