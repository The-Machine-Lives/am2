using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

[Token(Token = "0x200014A")]
public class BIScrollSnap : UIBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
{
	[Token(Token = "0x200063F")]
	public class SnapToTargetChanged : UnityEvent<GameObject>
	{
		[Token(Token = "0x6002D48")]
		[Address(RVA = "0xA43860", Offset = "0xA43860", VA = "0xA43860")]
		public SnapToTargetChanged()
		{
		}
	}

	[Token(Token = "0x4000825")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x824DFC", Offset = "0x824DFC")]
	private readonly SnapToTargetChanged _003CsnapTargetChanged_003Ek__BackingField;

	[Token(Token = "0x4000826")]
	[FieldOffset(Offset = "0x20")]
	public float speedThresholdToSnap;

	[Token(Token = "0x4000827")]
	[FieldOffset(Offset = "0x28")]
	public ScrollRect TargetScrollRect;

	[Token(Token = "0x4000828")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform ScrollContent;

	[Token(Token = "0x4000829")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 AutoScrollSpeed;

	[Token(Token = "0x400082A")]
	[FieldOffset(Offset = "0x40")]
	public bool snapForwardOnly;

	[Token(Token = "0x400082B")]
	[FieldOffset(Offset = "0x44")]
	public float snapForwardSpeedThreshold;

	[Token(Token = "0x400082C")]
	[FieldOffset(Offset = "0x48")]
	public bool snapEnabled;

	[Token(Token = "0x400082D")]
	[FieldOffset(Offset = "0x4C")]
	public float PixelThreshold;

	[Token(Token = "0x400082E")]
	[FieldOffset(Offset = "0x50")]
	public UnityEvent OnSnapTriggered;

	[Token(Token = "0x400082F")]
	[FieldOffset(Offset = "0x58")]
	private float PixelSnapForwardThreshold;

	[Token(Token = "0x4000830")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 goalDestination;

	[Token(Token = "0x4000831")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 previousContentPosition;

	[Token(Token = "0x4000832")]
	[FieldOffset(Offset = "0x74")]
	private bool isSnapping;

	[Token(Token = "0x4000833")]
	[FieldOffset(Offset = "0x75")]
	private bool foundObjectBefore;

	[Token(Token = "0x4000834")]
	[FieldOffset(Offset = "0x76")]
	private bool isDragging;

	[Token(Token = "0x4000835")]
	[FieldOffset(Offset = "0x78")]
	private GameObject m_currentClosestGameObject;

	[Token(Token = "0x17000109")]
	public SnapToTargetChanged snapTargetChanged
	{
		[Token(Token = "0x6000934")]
		[Address(RVA = "0xA42854", Offset = "0xA42854", VA = "0xA42854")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83451C", Offset = "0x83451C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000935")]
	[Address(RVA = "0xA4285C", Offset = "0xA4285C", VA = "0xA4285C", Slot = "8")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000936")]
	[Address(RVA = "0xA42898", Offset = "0xA42898", VA = "0xA42898")]
	private void Update()
	{
	}

	[Token(Token = "0x6000937")]
	[Address(RVA = "0xA42F7C", Offset = "0xA42F7C", VA = "0xA42F7C", Slot = "17")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000938")]
	[Address(RVA = "0xA42F8C", Offset = "0xA42F8C", VA = "0xA42F8C", Slot = "19")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000939")]
	[Address(RVA = "0xA42F90", Offset = "0xA42F90", VA = "0xA42F90", Slot = "18")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600093A")]
	[Address(RVA = "0xA42FEC", Offset = "0xA42FEC", VA = "0xA42FEC")]
	public void SnapToOffset(float _xOffset)
	{
	}

	[Token(Token = "0x600093B")]
	[Address(RVA = "0xA42FF0", Offset = "0xA42FF0", VA = "0xA42FF0")]
	public void CenterOn(RectTransform childTransform)
	{
	}

	[Token(Token = "0x600093C")]
	[Address(RVA = "0xA43294", Offset = "0xA43294", VA = "0xA43294")]
	private bool IsTargetSnapBeyondBounds(Vector2 goalDestination)
	{
		return default(bool);
	}

	[Token(Token = "0x600093D")]
	[Address(RVA = "0xA42B88", Offset = "0xA42B88", VA = "0xA42B88")]
	private void FindClosestObject(float _xOffset = 0f)
	{
	}

	[Token(Token = "0x600093E")]
	[Address(RVA = "0xA4329C", Offset = "0xA4329C", VA = "0xA4329C")]
	private bool ShouldSnapToVector(Vector3 toVector)
	{
		return default(bool);
	}

	[Token(Token = "0x600093F")]
	[Address(RVA = "0xA434EC", Offset = "0xA434EC", VA = "0xA434EC")]
	private Vector2 GetPixelCoords()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000940")]
	[Address(RVA = "0xA43654", Offset = "0xA43654", VA = "0xA43654")]
	private Vector2 GetNormalizedCoords(Vector2 PixelCoords)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000941")]
	[Address(RVA = "0xA43718", Offset = "0xA43718", VA = "0xA43718")]
	public BIScrollSnap()
	{
	}
}
