
using System;
using System.Collections;

namespace DfExample.DBFlute.MemberDb.AllCommon {

    public interface MbDaoWritable : MbDaoReadable {

        int Create(MbEntity entity);
        int Modify(MbEntity entity);
        int Remove(MbEntity entity);
    }
}
