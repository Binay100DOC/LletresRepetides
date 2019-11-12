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
                    Console.WriteLine("El nom no pot contenir numeros, com has posat aquí: "+j);
                }
            }
            Console.ReadKey();

            Console.WriteLine("!!!!!!!!!!!!!!!!!Fase 3!!!!!!!!!!!!!!!!!");

            int counter = 1;
            int counterRepeated = 1;
            Dictionary<char, int> myNameDictionary = new Dictionary<char, int>();
            for(int i = 0; i<nameList.Count; i++)
            {
               for(int j = 0; j<nameList.Count; j++)
                {
                    foreach(char k in nameList)
                    {
                        if(nameList[j] is in nameList[i])
                        {

                        }
                    }
                }
            }
        }
    }
}
