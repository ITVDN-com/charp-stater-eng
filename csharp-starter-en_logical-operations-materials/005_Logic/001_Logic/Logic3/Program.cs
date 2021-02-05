using System;

// Bitwise logical statements. (^)

// For example: 
// Using XOR operation, we can encrypt a message.
// In this form of encryption only a single key is used  for both encryption and decryption.
// Cryptographic strength of the key is possible to increase, increasing its length.

namespace Logic
{
    class Program
    {
        static void Main()
        {
            ushort secretKey = 0x0088; // Secret key (length - 16 bit).
            char character = 'A';      // Source symbol for encryption.

            Console.WriteLine("Source symbol is: {0}, its code in the code table: {1:X}", character, (byte)character);
            Console.WriteLine("Size of symbol: {0} = {1} bits", character, sizeof(char) * 8);

            // Encrypt symbol.
            character = (char)(character ^ secretKey);
            Console.WriteLine("The encrypted symbol is: {0}, its code in the code table: {1:X}", character, (byte)character);

            // Decrypt symbol.
            character = (char)(character ^ secretKey);
            Console.WriteLine("The decrypted symbol: {0}, its code in the code table: {1:X}", character, (byte)character);

            // Delay.
            Console.ReadKey();
        }
    }
}
