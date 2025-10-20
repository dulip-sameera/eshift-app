using eshift.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift.Dao
{
    internal interface ILoadDao
    {
        List<LoadDto> GetLoadsByJobId(int jobId);
    }
}
