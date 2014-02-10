
using System;
using System.Collections;

namespace DfExample.DBFlute.LibraryDb.AllCommon {

    public interface LdDaoWritable : LdDaoReadable {

        int Create(LdEntity entity);
        int Modify(LdEntity entity);
        int Remove(LdEntity entity);
    }
}
