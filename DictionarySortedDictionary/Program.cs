using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace DictionarySortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader streamReader = File.OpenText(path))
                {
                    while (!(streamReader.EndOfStream))
                    {
                        string[] vet = streamReader.ReadLine().Split(',');
                        string name = vet[0];
                        int num = int.Parse(vet[1]);
                        if (dictionary.ContainsKey(name))
                        {
                            dictionary[name] += num;
                        }
                        else
                        {
                            dictionary[name] = num;
                        }
                    }
                    foreach (KeyValuePair<string, int> dic in dictionary)
                    {
                        Console.WriteLine(dic.Key + ": " + dic.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("File not find: " + e.Message);
            }





        }
    }
}
