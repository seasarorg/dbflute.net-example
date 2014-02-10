
using System;

using DfExample.DBFlute.AllCommon.JavaLike;

namespace DfExample.DBFlute.AllCommon {

    public static class CDef {

        /**
         * フラグを示す
         */
        public class Flg {
            /** True: 有効を示す */
            public static readonly Flg True = new Flg("1", "True", "True");
            /** False: 無効を示す */
            public static readonly Flg False = new Flg("0", "False", "False");
            private static readonly Map<String, Flg> _codeValueMap = new LinkedHashMap<String, Flg>();
            static Flg() {
                _codeValueMap.put(True.Code.ToLower(), True);
                _codeValueMap.put(False.Code.ToLower(), False);
            }
            protected String _code; protected String _name; protected String _alias;
            public Flg(String code, String name, String alias) {
                _code = code; _name = name; _alias = alias;
            }
            public String Code { get { return _code; } }
            public String Name { get { return _name; } }
            public String Alias { get { return _alias; } }
            public static Flg CodeOf(Object code) {
                if (code == null) { return null; } if (code is Flg) { return (Flg)code; }
                return _codeValueMap.get(code.ToString().ToLower());
            }
            public static Flg[] Values { get {
                Flg[] values = new Flg[_codeValueMap.size()];
                int index = 0;
                foreach (Flg flg in _codeValueMap.values()) {
                    values[index] = flg;
                    ++index;
                }
                return values;
            }}
            public override int GetHashCode() { return 7 + _code.GetHashCode(); }
            public override bool Equals(Object obj) {
                if (!(obj is Flg)) { return false; }
                Flg cls = (Flg)obj;
                return _code.ToLower().Equals(cls.Code.ToLower());
            }
            public override String ToString() { return this.Code; }
        }

        /**
         * 会員の状態を示す
         */
        public class MemberStatus {
            /** Provisional: 仮会員を示す */
            public static readonly MemberStatus Provisional = new MemberStatus("PRV", "Provisional", "Provisional");
            /** Formalized: 正式会員を示す */
            public static readonly MemberStatus Formalized = new MemberStatus("FML", "Formalized", "Formalized");
            /** Withdrawal: 退会会員を示す */
            public static readonly MemberStatus Withdrawal = new MemberStatus("WDL", "Withdrawal", "Withdrawal");
            private static readonly Map<String, MemberStatus> _codeValueMap = new LinkedHashMap<String, MemberStatus>();
            static MemberStatus() {
                _codeValueMap.put(Provisional.Code.ToLower(), Provisional);
                _codeValueMap.put(Formalized.Code.ToLower(), Formalized);
                _codeValueMap.put(Withdrawal.Code.ToLower(), Withdrawal);
            }
            protected String _code; protected String _name; protected String _alias;
            public MemberStatus(String code, String name, String alias) {
                _code = code; _name = name; _alias = alias;
            }
            public String Code { get { return _code; } }
            public String Name { get { return _name; } }
            public String Alias { get { return _alias; } }
            public static MemberStatus CodeOf(Object code) {
                if (code == null) { return null; } if (code is MemberStatus) { return (MemberStatus)code; }
                return _codeValueMap.get(code.ToString().ToLower());
            }
            public static MemberStatus[] Values { get {
                MemberStatus[] values = new MemberStatus[_codeValueMap.size()];
                int index = 0;
                foreach (MemberStatus flg in _codeValueMap.values()) {
                    values[index] = flg;
                    ++index;
                }
                return values;
            }}
            public override int GetHashCode() { return 7 + _code.GetHashCode(); }
            public override bool Equals(Object obj) {
                if (!(obj is MemberStatus)) { return false; }
                MemberStatus cls = (MemberStatus)obj;
                return _code.ToLower().Equals(cls.Code.ToLower());
            }
            public override String ToString() { return this.Code; }
        }

    }

}
