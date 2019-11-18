using System;
using System.Collections.Generic;

namespace Exercici_LletresRepetides
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!!!!!!!!!!!!!!!!!Fase 1!!!!!!!!!!!!!!!!!");
            char[] nameArray = { 'B', 'I', 'N', 'A', 'Y' ,'4', 'A'};
            foreach(char i in nameArray)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

            Console.WriteLine("!!!!!!!!!!!!!!!!!Fase 2!!!!!!!!!!!!!!!!!");
            var nameList = new List<char>();

            for(int i = 0; i < nameArray.Length; i++)
            {
                nameList.Add(nameArray[i]);
            }

            foreach(char j in nameList)
            {
                if (j == 'A' || j == 'E' || j == 'I' || j == 'O' || j == 'U')
                {
                    Console.WriteLine(j+ " = Vocal");
                }
                else if(j>'A' && j <= 'Z')
                {
                    Console.WriteLine(j+ " = Consonant");
                }
                else if(j>'0' && '9' > j)
                {
                    Console.WriteLine(j+" = El nom no pot contenir numeros, com has posat aquí.");
                }
            }
            Console.ReadKey();

            Console.WriteLine("!!!!!!!!!!!!!!!!!Fase 3!!!!!!!!!!!!!!!!!");

            var myNameDictionary = new Dictionary<char, int>();
            for(int i = 0; i < nameList.Count; i++)
            {
                var key = nameList[i];
                if (myNameDictionary.ContainsKey(key))
                {
                    myNameDictionary[key]++;
                }
                else
                {
                    myNameDictionary.Add(nameList[i], 1);
                }
            }
            foreach (KeyValuePair<char, int> kvp in myNameDictionary)
            {
                Console.WriteLine("Char = {0}, Repetició = {1}", kvp.Key, kvp.Value);
            }

            Console.ReadKey();
            Console.WriteLine("!!!!!!!!!!!!!!!!!Fase 4!!!!!!!!!!!!!!!!!");

            char[] surnameArray = { 'T', 'i', 'm', 'i', 'l', 's', 'i', 'n', 'a' };
            var surNameList = new List<char>();
            var nomCompert = new List<char>();
            for(int i = 0; i < surnameArray.Length; i++)
            {
                surNameList.Add(surnameArray[i]);
            }
            foreach(char k in nameList)
            {
                nomCompert.Add(k);
            }
            nomCompert.Add(' ');
            foreach(char j in surNameList)
            {
                nomCompert.Add(j);
            }
            foreach(char k in nomCompert)
            {
                Console.WriteLine(k);
            }
            Console.ReadKey();
            

        }
    }
}
