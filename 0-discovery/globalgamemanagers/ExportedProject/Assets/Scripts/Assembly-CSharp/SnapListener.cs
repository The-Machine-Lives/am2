using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000159")]
internal class SnapListener<T> where T : MonoBehaviour
{
	[Token(Token = "0x4000876")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x824F54", Offset = "0x824F54")]
	private T _003CtargettedView_003Ek__BackingField;

	[Token(Token = "0x4000877")]
	[FieldOffset(Offset = "0x0")]
	private GameObject m_gameObject;

	[Token(Token = "0x4000878")]
	[FieldOffset(Offset = "0x0")]
	private BIScrollSnap m_scrollSnap;

	[Token(Token = "0x17000111")]
	public T targettedView
	{
		[Token(Token = "0x600097D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83453C", Offset = "0x83453C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600097E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83454C", Offset = "0x83454C")]
		private set
		{
		}
	}

	[Token(Token = "0x600097F")]
	public SnapListener(BIScrollSnap scrollSnap)
	{
	}

	[Token(Token = "0x6000980")]
	private void OnSnapTargetChanged(GameObject gameObject)
	{
	}
}
