
using System;
using System.Collections;

namespace DfExample.DBFlute.AllCommon {

    public interface DaoWritable : DaoReadable {

        int Create(Entity entity);
        int Modify(Entity entity);
        int Remove(Entity entity);
    }
}
