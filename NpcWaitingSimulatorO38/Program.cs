using System;
					
public class Program
{
	public static async Task Main()
	{
		await WaitForBlacksmith();
        await WaitForWizard();
        await WaitForMerchant();
	}
        
        //modifiers, task return type kinda, method name()  //plus parentheses
        static async Task WaitForBlacksmith()
        {
            string name = "John BlackSmith";
            Console.WriteLine($"{name} is busy");
            await Task.Delay(5000);
            System.Console.WriteLine($"*{name} is available* " + 
            " What can I hammer out for you today?");
        }

        static async Task WaitForWizard()
        {
            string name = "Gronzo the Black";
            Console.WriteLine($"\n{name} is busy");
            await Task.Delay(4000);
            Console.WriteLine($"{name} asks 'What kinda spell are you looking for today?' \n ");

        }

        static async Task WaitForMerchant()
        {
            string name = "Mr Midianite";
            Console.WriteLine($"{name} is busy");
            await Task.Delay(2000);
            System.Console.WriteLine($"{name} would like to trade");

        }


}



/* 
Assignment Goal
Understand how async methods simulate time-based events.

Assignment Concepts Covered
async methods

Task.Delay

awaiting multiple methods

Assignment Description
Create three async methods:

WaitForBlacksmith()
WaitForWizard()
WaitForMerchant()
Each method:

Prints that the NPC is busy

Waits a different amount of time

Prints when the NPC becomes available

Example delays:

Blacksmith: 2 seconds
Wizard: 4 seconds
Merchant: 1 second
Call them one at a time using await.

Example Output
Waiting for Blacksmith...
Blacksmith is ready!

Waiting for Wizard...
Wizard is ready!

Waiting for Merchant...
Merchant is ready!
Bonus Objectives
Add a random wait time between 1–5 seconds.
*/