using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000F8")]
public class ColoredPrefabSwapper<T> : PrefabSwapper<T> where T : Component, IColorable
{
	[Token(Token = "0x40005AC")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private AM2Button m_selectButton;

	[Token(Token = "0x40005AD")]
	[FieldOffset(Offset = "0x0")]
	private AutoScrollableView m_parentView;

	[Token(Token = "0x600068F")]
	protected void Awake()
	{
	}

	[Token(Token = "0x6000690")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x6000691")]
	public void Initialize(int prefabIndex, Color color, AutoScrollableView parentView)
	{
	}

	[Token(Token = "0x6000692")]
	public void SetColor(Color color)
	{
	}

	[Token(Token = "0x6000693")]
	protected void SelectButtonPressed()
	{
	}

	[Token(Token = "0x6000694")]
	public ColoredPrefabSwapper()
	{
	}
}
