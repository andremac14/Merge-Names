using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mergeNames
{
    class MergeNames
    {
        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            string[] addedNames = new string[6];

            for (int i = 0; i < names1.Length; i++)
            {

                addedNames[i] = names1[i];
            }

            int count = 2;

            for (int j = 0; j < 3; j++)
            {
                string stringToFind = names2[j];

                string result = Array.Find(addedNames, element => element == stringToFind);

                if (result == null)
                {

                    addedNames[count] = names2[j];

                }
                count++;
            }
            return addedNames;
        }

        public static void Main(string[] args)
        {
            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
            Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
        }
    }
}
