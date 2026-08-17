using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Observe;
using UnityEngine;

[Token(Token = "0x2000096")]
public class AdLoader : MonoBehaviour, IUkenObserver<UntouchedUIMessage>
{
	[Token(Token = "0x4000289")]
	[FieldOffset(Offset = "0x18")]
	private AdsController m_adsController;

	[Token(Token = "0x400028A")]
	[FieldOffset(Offset = "0x20")]
	private UkenUnsubscriber<UntouchedUIMessage> m_adsSignalHandle;

	[Token(Token = "0x600030E")]
	[Address(RVA = "0xACF388", Offset = "0xACF388", VA = "0xACF388")]
	private void Awake()
	{
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0xACF514", Offset = "0xACF514", VA = "0xACF514")]
	private void Start()
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0xACF544", Offset = "0xACF544", VA = "0xACF544")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0xACF5A4", Offset = "0xACF5A4", VA = "0xACF5A4", Slot = "4")]
	private void Uken_002ELibrary_002EObserve_002EIUkenObserver_003CUntouchedUIMessage_003E_002EOnEmit(UntouchedUIMessage message)
	{
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0xACF650", Offset = "0xACF650", VA = "0xACF650")]
	public AdLoader()
	{
	}
}
