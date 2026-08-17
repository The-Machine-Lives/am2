using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.Animation;
using UnityEngine;
using UnityEngine.UI;
using Utilities;

[Token(Token = "0x200012E")]
public class GraphicEffectView : MonoBehaviour
{
	[Token(Token = "0x40007A9")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected float m_stayStillDuration;

	[Token(Token = "0x40007AA")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	protected float m_stayFadeDuration;

	[Token(Token = "0x40007AB")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected Vector3 m_movement;

	[Token(Token = "0x40007AC")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	protected float m_movementDuration;

	[Token(Token = "0x40007AD")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	protected UkenAnimEaseType m_movementEaseType;

	[Token(Token = "0x40007AE")]
	[FieldOffset(Offset = "0x38")]
	protected Transform m_movementParent;

	[Token(Token = "0x40007AF")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	protected List<Graphic> m_targetGraphics;

	[Token(Token = "0x40007B0")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	protected float m_randomMovementX;

	[Token(Token = "0x40007B1")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_isInitValuesSet;

	[Token(Token = "0x40007B2")]
	[FieldOffset(Offset = "0x50")]
	private List<Color> m_initColors;

	[Token(Token = "0x40007B3")]
	[FieldOffset(Offset = "0x58")]
	private ObjectPoolController m_objectPoolController;

	[Token(Token = "0x60008B5")]
	[Address(RVA = "0x985BE4", Offset = "0x985BE4", VA = "0x985BE4")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60008B6")]
	[Address(RVA = "0x986118", Offset = "0x986118", VA = "0x986118")]
	protected void OnComplete()
	{
	}

	[Token(Token = "0x60008B7")]
	[Address(RVA = "0x98611C", Offset = "0x98611C", VA = "0x98611C")]
	private void HandleCleanup()
	{
	}

	[Token(Token = "0x60008B8")]
	[Address(RVA = "0x98627C", Offset = "0x98627C", VA = "0x98627C")]
	public GraphicEffectView()
	{
	}
}
