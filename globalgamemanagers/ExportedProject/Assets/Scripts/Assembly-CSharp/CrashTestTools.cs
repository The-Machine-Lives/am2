using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200012C")]
public class CrashTestTools : MonoBehaviour
{
	[Token(Token = "0x40007A2")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Button divideByZeroButton;

	[Token(Token = "0x40007A3")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Button nullRefButton;

	[Token(Token = "0x40007A4")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Button stackOverflowButton;

	[Token(Token = "0x40007A5")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Button argOutOfRangeButton;

	[Token(Token = "0x40007A6")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Button appThrowButton;

	[Token(Token = "0x40007A7")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Button notImplementedButton;

	[Token(Token = "0x40007A8")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Button crashlyticsException;

	[Token(Token = "0x60008A7")]
	[Address(RVA = "0x9C0CF0", Offset = "0x9C0CF0", VA = "0x9C0CF0")]
	private void Start()
	{
	}

	[Token(Token = "0x60008A8")]
	[Address(RVA = "0x9C0FF8", Offset = "0x9C0FF8", VA = "0x9C0FF8")]
	private void DivideByZeroCrash()
	{
	}

	[Token(Token = "0x60008A9")]
	[Address(RVA = "0x9C0FFC", Offset = "0x9C0FFC", VA = "0x9C0FFC")]
	private void NullRefCrash()
	{
	}

	[Token(Token = "0x60008AA")]
	[Address(RVA = "0x9C1040", Offset = "0x9C1040", VA = "0x9C1040")]
	private void StackOverflowCrash()
	{
	}

	[Token(Token = "0x60008AB")]
	[Address(RVA = "0x9C1044", Offset = "0x9C1044", VA = "0x9C1044")]
	private void ArgOutOfRange()
	{
	}

	[Token(Token = "0x60008AC")]
	[Address(RVA = "0x9C10C4", Offset = "0x9C10C4", VA = "0x9C10C4")]
	public void AppThrowCrash()
	{
	}

	[Token(Token = "0x60008AD")]
	[Address(RVA = "0x9C1144", Offset = "0x9C1144", VA = "0x9C1144")]
	public void NotImplementedCrash()
	{
	}

	[Token(Token = "0x60008AE")]
	[Address(RVA = "0x9C11AC", Offset = "0x9C11AC", VA = "0x9C11AC")]
	public void CrashlyticsException()
	{
	}

	[Token(Token = "0x60008AF")]
	[Address(RVA = "0x9C120C", Offset = "0x9C120C", VA = "0x9C120C")]
	public CrashTestTools()
	{
	}
}
