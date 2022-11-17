using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000FA")]
public class PrefabSwapper<T> : MonoBehaviour where T : Component
{
	[Token(Token = "0x40005C0")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected T[] m_prefabTemplates;

	[Token(Token = "0x40005C1")]
	[FieldOffset(Offset = "0x0")]
	protected T m_currentPrefab;

	[Token(Token = "0x40005C2")]
	[FieldOffset(Offset = "0x0")]
	protected int m_currentPrefabIndex;

	[Token(Token = "0x40005C3")]
	[FieldOffset(Offset = "0x0")]
	protected T[] m_cachedPrefabs;

	[Token(Token = "0x60006A5")]
	public virtual void Initialize(int prefabIndex)
	{
	}

	[Token(Token = "0x60006A6")]
	public T SwapPrefabByIndex(int prefabIndex)
	{
		return null;
	}

	[Token(Token = "0x60006A7")]
	public virtual void OnCurrentPrefabInstantiated()
	{
	}

	[Token(Token = "0x60006A8")]
	private T GetCachedPrefab(int prefabIndex)
	{
		return null;
	}

	[Token(Token = "0x60006A9")]
	private void CacheCurrentPrefab()
	{
	}

	[Token(Token = "0x60006AA")]
	public PrefabSwapper()
	{
	}
}
