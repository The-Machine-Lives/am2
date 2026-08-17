using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x20000FC")]
public class ScrollableSelector<T> : MonoBehaviour where T : MonoBehaviour
{
	[Token(Token = "0x40005D5")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private Transform m_itemsContainer;

	[Token(Token = "0x40005D6")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private BIScrollSnap m_scrollSnap;

	[Token(Token = "0x40005D7")]
	[FieldOffset(Offset = "0x0")]
	private SnapListener<T> m_snapListener;

	[Token(Token = "0x170000E0")]
	public Transform itemsContainer
	{
		[Token(Token = "0x60006B7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000E1")]
	public T selectedItem
	{
		[Token(Token = "0x60006B8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60006B9")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x60006BA")]
	public void AddListener(UnityAction<GameObject> onTargetChangedListener)
	{
	}

	[Token(Token = "0x60006BB")]
	public void RemoveListener(UnityAction<GameObject> onTargetChangedListener)
	{
	}

	[Token(Token = "0x60006BC")]
	public ScrollableSelector()
	{
	}
}
