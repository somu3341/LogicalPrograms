using System;
namespace LogicalPrograms
{
    public class VendingMachine
    {
        int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
        public void changereturned(int amount)
        {
            //int count = 0;
            Console.WriteLine("Note's change available");
            for (int i = 0; i < notes.Length; i++) 
            {
                if (amount / notes[i] >= 1 && amount != 0)
                {
                    int change = amount / notes[i];                 
                    if (change >= 1)
                    {                       
                        int c = notes[i]*change;
                        amount = amount - c;
                        Console.WriteLine(notes[i] + "Rupee notes= " + change);
                    }                   
                }              
            }
        }
    }
}
