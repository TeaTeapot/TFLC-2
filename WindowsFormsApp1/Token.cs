using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor
{
    public class TokenTypeInfo
    {
        public int Code { get; set; }
        public string Description { get; set; }

        public TokenTypeInfo(int code, string description)
        {
            Code = code;
            Description = description;
        }
    }
    public class Token
    {
        public TokenTypeInfo TypeInfo { get; set; }
        public string Value { get; set; }
        public int Line { get; set; }
        public int StartPos { get; set; }
        public int EndPos { get; set; }

        public int Code => TypeInfo?.Code ?? -1;
        public string Type => TypeInfo?.Description ?? "Ошибка";
        public string Position => $"{Line}:{StartPos}-{EndPos}";
    }
}