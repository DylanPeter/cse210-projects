using System.Collections.Generic;
using System;
namespace Develop02
{
    public class Progam
    {
        static void Main(string[] args)
        {
            Entry myEntry = new Entry();
            myEntry.StorePrompt("What is your name?");
            myEntry.StoreResponse("Dylan Petersen");
            myEntry.StoreDate("May 8 2023");

            Entry yourEntry = new Entry();
            yourEntry.StorePrompt("What is your favorite food?");
            yourEntry.StoreResponse("Pizza");
            yourEntry.StoreDate("8 May 2023");


            Journal journal = new Journal();
            journal.StoreEntry(myEntry);
            journal.StoreEntry(yourEntry);

            List<Entry> entries = journal.GetEntries();
            foreach (Entry entry in entries)
            {
                string message 
                    = $"{entry.GetDate()}\n{entry.GetPrompt()}\n{entry.GetResponse()}\n";
                Console.WriteLine(message);
            }
        }
    }
}  