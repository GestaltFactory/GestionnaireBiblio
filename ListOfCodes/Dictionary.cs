using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfCodes
{
    class Dictionary
    {
        static void Main(string[] args)
        {
 

 /*           
        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<char, Customer> persons = new Dictionary<char, Customer>();
            persons.Add('l', new Customer() { Name = "Lili" });
            persons.Add('s', new Customer() { Name = "Sylia" });
            persons.Add('n', new Customer() { Name = "Nina" });

            foreach (KeyValuePair<char, Customer> keyValue in persons)
            {
                // keyValue.Value present class Customer
                MessageBox.Show(keyValue.Key + " - " + keyValue.Value.Name);
            }

            // loop keys
            foreach (char c in persons.Keys)
            {
                MessageBox.Show (Convert.ToString(c));
            }

            // loop values
            foreach (Customer p in persons.Values)
            {
                MessageBox.Show(p.Name);
            }

*/

/*
            Employee e1;
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(e1.Code, e1.Name);

            private void buttonDictionary_Click(object sender, EventArgs e)
            {
                listBoxDictionary.Items.Clear();
                foreach(KeyValuePair<int, string> pair in dictionary){
                    listBoxDictionary.Items.Add(pair);
                }
            }
 */           
            
            Dictionary<string, int> dictionary1 = new Dictionary<string, int>();

            dictionary1.Add("cat", 2);
            dictionary1.Add("dog", 1);
            dictionary1.Add("llama", 0);
            dictionary1.Add("iguana", -1);


            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            dictionary.Add("apple", 1);
            dictionary.Add("windows", 5);

            // See whether Dictionary contains this string.
            if (dictionary.ContainsKey("apple"))
            {
                int value = dictionary["apple"];
                Console.WriteLine(value);
            }

            // See whether it contains this string.
            if (!dictionary.ContainsKey("acorn"))
            {
                Console.WriteLine(false);
            }





            // Example Dictionary again.
            Dictionary<string, int> d = new Dictionary<string, int>(){
	            {"cat", 2},
	            {"dog", 1},
	            {"llama", 0},
	            {"iguana", -1}
	        };

            // Loop over pairs with foreach.
            foreach (KeyValuePair<string, int> pair in d)
            {
                Console.WriteLine("{0}, {1}",
                pair.Key,
                pair.Value);
            }
            // Use var keyword to enumerate dictionary.
            foreach (var pair in d)
            {
                Console.WriteLine("{0}, {1}",
                pair.Key,
                pair.Value);
            }





            Dictionary<string, int> d2 = new Dictionary<string, int>(){
	            {"cat", 2},
	            {"dog", 1},
	            {"llama", 0},
	            {"iguana", -1}
	        };
            // Store keys in a List
            List<string> list = new List<string>(d2.Keys);
            // Loop through list
            foreach (string k in list){
                Console.WriteLine("{0}, {1}",
                k,
                d2[k]);
            }




            // Use a Dictionary with an int key to sort.
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(100, "Bill");
            dict.Add(200, "Steve");
            // We can look up the int in the Dictionary.
            if (dict.ContainsKey(200))
            {
                Console.WriteLine(true);
            }



            //contains value
            Dictionary<string, int> d3 = new Dictionary<string, int>();
            d3.Add("cat", 1);
            d3.Add("dog", 2);
            if (d3.ContainsValue(1))
            {
                Console.WriteLine(true); // True.
            }


            //remove from list
            Dictionary<string, int> d4 = new Dictionary<string, int>();
            d4.Add("cat", 1);
            d4.Add("dog", 2);

            d4.Remove("cat"); // Removes cat.
        }
    }
}
