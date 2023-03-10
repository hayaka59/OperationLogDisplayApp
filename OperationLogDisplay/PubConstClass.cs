
namespace OperationLogDisplay
{

    public class PubConstClass
    {
        public const string DEF_VERSION = "Ver.0.0.0.1";                // バージョン情報 
        public const string DEF_FILENAME = "OperationLogDisplay.def";   // DEFファイル名称

        public static object objSyncHist = new();

        public const string DEF_IP_ADDRESS1 = "1号機IPアドレス";
        public const string DEF_IP_ADDRESS2 = "2号機IPアドレス";
        public const string DEF_HOST_NAME1 = "1号機ホスト名";
        public const string DEF_HOST_NAME2 = "2号機ホスト名";

        public static string? pblIpAddress1;
        public static string? pblIpAddress2;
        public static string? pblHostName1;
        public static string? pblHostName2;
    }
}
