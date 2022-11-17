using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Utilities
{
	[Token(Token = "0x2000309")]
	public class Pool
	{
		[Token(Token = "0x4000E18")]
		[FieldOffset(Offset = "0x10")]
		private int m_allCout;

		[Token(Token = "0x4000E19")]
		[FieldOffset(Offset = "0x18")]
		private Stack<GameObject> m_inactive;

		[Token(Token = "0x4000E1A")]
		[FieldOffset(Offset = "0x20")]
		private GameObject m_prefab;

		[Token(Token = "0x4000E1B")]
		[FieldOffset(Offset = "0x28")]
		private int m_nextId;

		[Token(Token = "0x4000E1C")]
		[FieldOffset(Offset = "0x2C")]
		private int m_sizeLimit;

		[Token(Token = "0x4000E1D")]
		[FieldOffset(Offset = "0x30")]
		private Transform m_despawnParent;

		[Token(Token = "0x60017DD")]
		[Address(RVA = "0xAB7364", Offset = "0xAB7364", VA = "0xAB7364")]
		public Pool(GameObject prefab, int sizeLimit, Transform despawnParent)
		{
		}

		[Token(Token = "0x60017DE")]
		[Address(RVA = "0xAB6B30", Offset = "0xAB6B30", VA = "0xAB6B30")]
		public GameObject Spawn(Transform parent, Vector3 pos, Quaternion rot, Vector3 sca)
		{
			return null;
		}

		[Token(Token = "0x60017DF")]
		[Address(RVA = "0xAB7268", Offset = "0xAB7268", VA = "0xAB7268")]
		public void Despawn(GameObject obj)
		{
		}
	}
}
