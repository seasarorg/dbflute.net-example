
using System;

using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;

namespace DfExample.DBFlute.LibraryDb.AllCommon {

    public static class LdCDef {

        /**
         * はいいいえを示す
         */
        public class YesNo {
            /** はい */
            public static readonly YesNo Yes = new YesNo("y", "Yes", "はい");
            /** いいえ */
            public static readonly YesNo No = new YesNo("n", "No", "いいえ");
            private static readonly Map<String, YesNo> _codeValueMap = new LinkedHashMap<String, YesNo>();
            static YesNo() {
                _codeValueMap.put(Yes.Code.ToLower(), Yes);
                _codeValueMap.put(No.Code.ToLower(), No);
            }
            protected String _code; protected String _name; protected String _alias;
            public YesNo(String code, String name, String alias) {
                _code = code; _name = name; _alias = alias;
            }
            public String Code { get { return _code; } }
            public String Name { get { return _name; } }
            public String Alias { get { return _alias; } }
            public static YesNo CodeOf(Object code) {
                if (code == null) { return null; } if (code is YesNo) { return (YesNo)code; }
                return _codeValueMap.get(code.ToString().ToLower());
            }
            public static YesNo[] Values { get {
                YesNo[] values = new YesNo[_codeValueMap.size()];
                int index = 0;
                foreach (YesNo flg in _codeValueMap.values()) {
                    values[index] = flg;
                    ++index;
                }
                return values;
            }}
            public override int GetHashCode() { return 7 + _code.GetHashCode(); }
            public override bool Equals(Object obj) {
                if (!(obj is YesNo)) { return false; }
                YesNo cls = (YesNo)obj;
                return _code.ToLower().Equals(cls.Code.ToLower());
            }
            public override String ToString() { return this.Code; }
        }

        /**
         * 蔵書の状態を示す
         */
        public class CollectionStatus {
            /** NOR: 通常状態を示す */
            public static readonly CollectionStatus NOR = new CollectionStatus("NOR", "NOR", "NOR");
            /** WAT: 待ち状態を示す */
            public static readonly CollectionStatus WAT = new CollectionStatus("WAT", "WAT", "WAT");
            /** OUT: 貸し出し中を示す */
            public static readonly CollectionStatus OUT = new CollectionStatus("OUT", "OUT", "OUT");
            private static readonly Map<String, CollectionStatus> _codeValueMap = new LinkedHashMap<String, CollectionStatus>();
            static CollectionStatus() {
                _codeValueMap.put(NOR.Code.ToLower(), NOR);
                _codeValueMap.put(WAT.Code.ToLower(), WAT);
                _codeValueMap.put(OUT.Code.ToLower(), OUT);
            }
            protected String _code; protected String _name; protected String _alias;
            public CollectionStatus(String code, String name, String alias) {
                _code = code; _name = name; _alias = alias;
            }
            public String Code { get { return _code; } }
            public String Name { get { return _name; } }
            public String Alias { get { return _alias; } }
            public static CollectionStatus CodeOf(Object code) {
                if (code == null) { return null; } if (code is CollectionStatus) { return (CollectionStatus)code; }
                return _codeValueMap.get(code.ToString().ToLower());
            }
            public static CollectionStatus[] Values { get {
                CollectionStatus[] values = new CollectionStatus[_codeValueMap.size()];
                int index = 0;
                foreach (CollectionStatus flg in _codeValueMap.values()) {
                    values[index] = flg;
                    ++index;
                }
                return values;
            }}
            public override int GetHashCode() { return 7 + _code.GetHashCode(); }
            public override bool Equals(Object obj) {
                if (!(obj is CollectionStatus)) { return false; }
                CollectionStatus cls = (CollectionStatus)obj;
                return _code.ToLower().Equals(cls.Code.ToLower());
            }
            public override String ToString() { return this.Code; }
        }

    }

}
