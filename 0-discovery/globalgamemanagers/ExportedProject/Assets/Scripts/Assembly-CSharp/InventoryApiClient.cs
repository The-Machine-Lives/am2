using System;
using System.Collections.Generic;
using Com.Uken.ApiClient;
using Il2CppDummyDll;

[Token(Token = "0x2000217")]
public class InventoryApiClient : ApiClient
{
	[Token(Token = "0x6000E51")]
	[Address(RVA = "0x98E0D8", Offset = "0x98E0D8", VA = "0x98E0D8")]
	public InventoryApiClient(InventoryApiConfig config)
	{
	}

	[Token(Token = "0x6000E52")]
	[Address(RVA = "0x98E0E0", Offset = "0x98E0E0", VA = "0x98E0E0")]
	public void DeleteItem(string inventoryToken, HashSet<string> itemsToDelete, Action<Dictionary<string, string>, string> successCallback, Action<Dictionary<string, string>, long, string> errorCallback)
	{
	}
}
