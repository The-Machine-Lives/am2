using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000098")]
public class DynamicAdOrbit : MonoBehaviour, IPositionAnimator
{
	[Token(Token = "0x40002A0")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float m_dynamicAdOrbitSpeed;

	[Token(Token = "0x40002A1")]
	[FieldOffset(Offset = "0x20")]
	private Transform m_objectTransform;

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x9C3748", Offset = "0x9C3748", VA = "0x9C3748")]
	private void Awake()
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x9C3770", Offset = "0x9C3770", VA = "0x9C3770", Slot = "6")]
	public void SetPositionAndRotation(Vector3 position, Quaternion rotation)
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x9C37F8", Offset = "0x9C37F8", VA = "0x9C37F8", Slot = "7")]
	public void UpdatePosition()
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x9C38D8", Offset = "0x9C38D8", VA = "0x9C38D8", Slot = "4")]
	public void SetPosition(Vector3 position)
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x9C3930", Offset = "0x9C3930", VA = "0x9C3930", Slot = "5")]
	public void SetRotation(Quaternion quaternion)
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x9C3990", Offset = "0x9C3990", VA = "0x9C3990")]
	public DynamicAdOrbit()
	{
	}
}
