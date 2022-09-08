using Bogus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Nist.Oscal.Tests.Bogus
{
    public static class UuidExtension
    {
        public static Guid UuidV4(this Randomizer randomizer)
        {
            var version = 4;
            var guidBytes = randomizer.Bytes(16);
            // set the four most significant bits (bits 12 through 15) of the time_hi_and_version field to the appropriate 4-bit version number from Section 4.1.3 (step 8)
            guidBytes[6] = (byte)((guidBytes[6] & 0x0F) | (version << 4));

            // set the two most significant bits (bits 6 and 7) of the clock_seq_hi_and_reserved to zero and one, respectively (step 10)
            guidBytes[8] = (byte)((guidBytes[8] & 0x3F) | 0x80);

            // convert the resulting UUID to local byte order (step 13)
            SwapByteOrder(guidBytes);
            return new Guid(guidBytes);

            static void SwapByteOrder(byte[] guid)
            {
                SwapBytes(guid, 0, 3);
                SwapBytes(guid, 1, 2);
                SwapBytes(guid, 4, 5);
                SwapBytes(guid, 6, 7);
            }

            static void SwapBytes(byte[] guid, int left, int right)
            {
                byte temp = guid[left];
                guid[left] = guid[right];
                guid[right] = temp;
            }
        }
    }
}
