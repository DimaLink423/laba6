using System;
using System.Text;


// proba 1
namespace AES
{

    // class num 1
    class Program
    {
        static void Main(string[] args)
        {
            AES aes = new AES(Encoding.UTF8.GetBytes("1234password1234"));

        byte[] text = Encoding.UTF8.GetBytes("Some text here!!");
        if (aes.Encrypt(text, ref text))
            {
                Console.WriteLine("Зашифрований текст = " + Encoding.UTF8.GetString(text));
                aes.Decrypt(text, ref text);
                Console.WriteLine("Розшифрований текст = " + Encoding.UTF8.GetString(text));
            }
            else
                Console.WriteLine("Невірні дані!");





        }
    }
}