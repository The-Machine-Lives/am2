using Il2CppDummyDll;

namespace Uken.Library.Inventory
{
	[Token(Token = "0x2000455")]
	public interface IEquipmentItem
	{
		[Token(Token = "0x6001FF7")]
		string GetEquipmentModelReference();

		[Token(Token = "0x6001FF8")]
		void SetEquipmentModelReference(string itemRef);
	}
}
