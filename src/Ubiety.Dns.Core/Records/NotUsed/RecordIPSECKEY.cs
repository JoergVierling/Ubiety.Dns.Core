using System;
/*

 */

namespace Heijden.DNS
{
        /// <summary>
        /// </summary>
    public class RecordIPSECKEY : Record
    {
        /// <summary>
        /// </summary>
        public byte[] RDATA;

        /// <summary>
        /// </summary>
        public RecordIPSECKEY(RecordReader rr)
        {
            // re-read length
            ushort RDLENGTH = rr.ReadUInt16(-2);
            RDATA = rr.ReadBytes(RDLENGTH);
        }

        /// <summary>
        /// </summary>
        public override string ToString()
        {
            return string.Format("not-used");
        }

    }
}