using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationLogDisplay
{

    public class PubConstClass
    {
        public const string DEF_VERSION = "Ver.0.0.0.1";                // バージョン情報 
        public const string DEF_FILENAME = "OperationLogDisplay.def";   // DEFファイル名称

        public static object? objSyncHist;

        public const string DEF_IP_ADDRESS1 = "1号機IPアドレス";
        public const string DEF_IP_ADDRESS2 = "2号機IPアドレス";

        public static string? pblIpAddress1;
        public static string? pblIpAddress2;
    }
}
