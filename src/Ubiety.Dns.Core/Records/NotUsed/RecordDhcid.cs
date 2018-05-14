using System;
using System.Collections.ObjectModel;

namespace Ubiety.Dns.Core.Records.NotUsed
{
    /// <summary>
    ///     DCHP information resource record
    /// </summary>
    public class RecordDhcid : Record
    {
        private readonly Collection<Byte> data;

        /// <summary>
        ///     Initializes a new instance of the <see cref="RecordDhcid" /> class
        /// </summary>
        /// <param name="rr"><see cref="RecordReader" /> for the record data</param>
        public RecordDhcid(RecordReader rr)
        {
            // re-read length
            UInt16 length = rr.ReadUInt16(-2);
            this.data = new Collection<Byte>(rr.ReadBytes(length));
        }

        /// <summary>
        ///     Gets the record data
        /// </summary>
        public Collection<Byte> RecordData { get => this.data; }

        /// <summary>
        ///     String representation of the record
        /// </summary>
        /// <returns>String version of the record</returns>
        public override String ToString()
        {
            return "not-used";
        }
    }
}