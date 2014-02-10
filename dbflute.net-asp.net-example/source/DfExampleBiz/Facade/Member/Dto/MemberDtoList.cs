using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DfExampleBiz.Facade.Member.Dto
{
    public class MemberDtoList
    {
        public IList<MemberDto> MemberList { get; set; }

        public int AllRecordCount { get; set; }

        
    }
}
