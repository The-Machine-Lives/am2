using Il2CppDummyDll;

namespace GooglePlayGames
{
	[Token(Token = "0x2000249")]
	public static class GameInfo
	{
		[Token(Token = "0x4000CAD")]
		private const string UnescapedApplicationId = "APP_ID";

		[Token(Token = "0x4000CAE")]
		private const string UnescapedIosClientId = "IOS_CLIENTID";

		[Token(Token = "0x4000CAF")]
		private const string UnescapedWebClientId = "WEB_CLIENTID";

		[Token(Token = "0x4000CB0")]
		private const string UnescapedNearbyServiceId = "NEARBY_SERVICE_ID";

		[Token(Token = "0x4000CB1")]
		public const string ApplicationId = "12040194530";

		[Token(Token = "0x4000CB2")]
		public const string IosClientId = "__IOS_CLIENTID__";

		[Token(Token = "0x4000CB3")]
		public const string WebClientId = "12040194530-i6a14qbrujb0a5736f77aq7v4v2qm022.apps.googleusercontent.com";

		[Token(Token = "0x4000CB4")]
		public const string NearbyConnectionServiceId = "";

		[Token(Token = "0x600108B")]
		[Address(RVA = "0x1466C40", Offset = "0x1466C40", VA = "0x1466C40")]
		public static bool ApplicationIdInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x600108C")]
		[Address(RVA = "0x1466D30", Offset = "0x1466D30", VA = "0x1466D30")]
		public static bool IosClientIdInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x600108D")]
		[Address(RVA = "0x1466DCC", Offset = "0x1466DCC", VA = "0x1466DCC")]
		public static bool WebClientIdInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x600108E")]
		[Address(RVA = "0x1466E68", Offset = "0x1466E68", VA = "0x1466E68")]
		public static bool NearbyConnectionsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x600108F")]
		[Address(RVA = "0x1466CDC", Offset = "0x1466CDC", VA = "0x1466CDC")]
		private static string ToEscapedToken(string token)
		{
			return null;
		}
	}
}
