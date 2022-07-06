using System;
using System.IO;

/* 
* RManager - A program that writes input string data to a file and outputs the data when prompted by a command.
*/

namespace Manager{


    class Program{

        
        static void Work(){

            string Path = "C:/Users/spook/Desktop/dataRManager.txt"; // Path to file with data
            int i = 0; 
            /*This is a counter. It is assigned the value 0, 
            the counter is designed to turn off the program. 
            If the user enters the exit command on the command line (without filling in the data for the file), 
            then the counter changes to 1 and the loop ends*/

            while(i == 0){
                string? tick = Console.ReadLine();

                if (tick?.ToLower() == "help"){ // list of command
                    Console.WriteLine("If you need command list press - \' list \'");
                    Console.WriteLine("If you need create new task press - \' new \'");
                    Console.WriteLine("If you need exit this proggram press - \' exit \'");
                }
                if (tick?.ToLower() == "list"){ // check list exists

                    if (File.Exists(Path) == true){

                        string readText = File.ReadAllText("C:/Users/spook/Desktop/dataRManager.txt");
                        Console.WriteLine(readText);
                        Console.WriteLine("OK, what next?");
                    }
                    else if (File.Exists(Path) == false) {

                        File.Create(Path);
                        Console.WriteLine("List don\'t exists. I create it.");
                    }
                    else{

                        Console.WriteLine("Error. Something wrong.");
                    }
                }
                if (tick?.ToLower() == "new"){ // add sting in file with data

                    Console.WriteLine("OK, what the new ticket? Set name new ticket:");
                    string? ticketName = Console.ReadLine();
                    Console.WriteLine("Now set a discriptions to the ticket");
                    string? ticketDiscription = Console.ReadLine();
                    Console.WriteLine("OK, who is worker?");
                    string? ticketWorker = Console.ReadLine();
  
                    File.AppendAllText(Path,"Name: " + ticketName + "\n" + "Discription: " + ticketDiscription + 
                    "\n" + "Worker: " + ticketWorker + "\n \n");
                    Console.WriteLine("Ticket add in file. What next?");
                            
                        
                }
                if (tick?.ToLower() == "exit"){ // program end

                    i = 1;
                    Console.WriteLine("See you space, cowboy.");
                }
            }
        }

         static void Main(string[] args){

            // Greeting and Starting the Work Method
            Console.WriteLine("Hello, this is \"RManager alfa 0.1\" ");
            Console.WriteLine("What i need to do? If you don\'t now command, press \'help\'");
            Work();
            
         }
    }
}