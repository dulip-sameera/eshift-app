using eshift.Dao;
using eshift.Dao.Impl;
using System;

namespace eshift.Utils.Generator
{
    internal static class TransportUnitIdGenerator
    {
        public static string GenerateNextTransportUnitId()
        {
            ITransportUnitDao dao = new TransportUnitDaoImpl();
            string? lastId = dao.GetLastTransportUnitId();
            string year = DateTime.Now.Year.ToString();
            int sequence = 1;

            if (!string.IsNullOrWhiteSpace(lastId) && lastId.Length == 11)
            {
                string lastYear = lastId.Substring(2, 4);
                string lastSeq = lastId.Substring(6, 5);
                if (lastYear == year)
                {
                    if (int.TryParse(lastSeq, out int lastSeqNum))
                        sequence = lastSeqNum + 1;
                }
            }
            return $"TU{year}{sequence.ToString("D5")}";
        }
    }
}