using System;

namespace BasicTypes
{
    class Program
    {
        static void Main()
        {
            #region INTEGER TYPES

            // 8-bits == 1 byte. ----------------------------------------------------------------------------

            // Integer without a sign. Range - from 0 to 255.
            byte a = 0;
            Byte b = 255;

            // Integer with a sign. Range - from -128 to +127.
            sbyte c = -128;
            SByte d = +127;


            // 16-bits == 2 bytes. -------------------------------------------------------------------------

            // Integer without a sign. Range - from 0 to 65535.
            ushort e = 0;
            UInt16 f = 65535;

            // Integer with a sign. Range - from -32768 to +32767.
            short g = -32768;
            Int16 h = +32767;


            // 32-bits = 4 bytes. ---------------------------------------------------------------------------

            // Integer without a sign. Range - from 0 to 4294967295.
            uint i = 0u;
            UInt32 j = 4294967295U;

            // Integer with a sign. Range - from -2147483648 to +2147483647.
            int k = -2147483648;
            Int32 l = +2147483647;


            // 64-bits = 8 bytes. ---------------------------------------------------------------------------

            // Integer without a sign. Range - from 0 to 18446744073709551615.
            ulong m = 0ul;
            UInt64 n = 18446744073709551615UL;

            // Integer with a sign. Range - from -9223372036854775808 to +9223372036854775807.
            long o = -9223372036854775808L;
            Int64 p = +9223372036854775807L;

            #endregion


            #region REAL TYPES

            // Real types are intended to represent fractional numbers.

            // 32-bits = 4 bytes. ---------------------------------------------------------------------------

            // Real with a sign. Range - from +/-1.5 x 10^-45 to +/-3.4 x 10^38.
            float q = -0.123456789f;  // To specify suffix f is required, 
            Single r = +1.123456789F; // because compiler interprets this number as a double.


            // 64-bits = 8 bytes. ---------------------------------------------------------------------------

            // Real with a sign. Range - from +/-5.0 x 10^-324 to +/-1.7 x 10^308.
            double s = -0.123456789d;
            Double t = +1.123456789;

            #endregion


            #region DECIMAL TYPE

            // 128-bits = 16 bytes. -----------------------------------------------------------------------

            // Decimal with a sign. Range - from +/-1.0 x 10^-28 to +/-7.9 x 10^28.
            decimal u = -0.12345m;   // To specify the suffix m is required,  
            Decimal v = +1.1234567M; // because the compiler interprets this number as a double.

            #endregion


            #region BOOLEAN TYPES

            // 8-bits == 1 byte. ----------------------------------------------------------------------------

            // Logical value True / False.
            bool w = true;
            Boolean x = false;

            #endregion


            #region CHARACTER TYPE

            // 16-bits == 2 bytes. -------------------------------------------------------------------------

            // Character in UNICODE format.
            char y = 'a';
            Char z = 'A';

            #endregion


            #region STRING TYPE

            // String in UNICODE format.
            string firstString = "hello";
            String secondString = "HELLO";

            #endregion


            // Delay.
            Console.ReadKey();
        }
    }
}
