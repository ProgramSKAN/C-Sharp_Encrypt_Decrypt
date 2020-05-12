using System;
namespace CSharp_Encrypt_Decrypt
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("AES Encyption Decryption Wizard");
            Console.WriteLine("================================");
            Console.WriteLine("Choose one of the following options");
            Console.WriteLine("1.Encrypt Text");
            Console.WriteLine("2.Decrypt Text");

            string optionSelected = Console.ReadLine();

            switch (Convert.ToInt32(optionSelected))
            {
                case 1:
                    EncryptText();
                    break;

                case 2:
                    DecryptText();
                    break;
            }
            Console.ReadKey();
        }
        private static void EncryptText()
        {
            Console.Clear();
            Console.Write("Enter Plain Text to Encrypt:");
            string plainText = Console.ReadLine();
            Console.WriteLine("Encrypted Text: "+ plainText.EncryptText());
        }
        private static void DecryptText()
        {
            Console.Clear();
            Console.Write("Enter Plain Text to Decrypt:");
            string plainText = Console.ReadLine();
            try
            {
                Console.WriteLine("Decrypted Text: "+plainText.DecryptText());
            }
            catch
            {
                Console.WriteLine("Invalid Encrypted String");
            }
        }
    }
}
