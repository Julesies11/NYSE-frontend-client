using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DiaryFrontEnd.UserInterfaces
{
    public static class StartingUserInterface
    {
        public static bool Quit = false;
        public static Diary diary = new Diary();

        public static void CommandLoop()
        {
            while (!Quit)
            {
                Console.WriteLine(string.Empty);
                HelpCommand();
                var command = Console.ReadLine().ToLower();
                CommandRoute(command);
            }
        }

        public static void CommandRoute(string command)
        {

            if (command.StartsWith("add"))
                AddCommand();
            else if (command.StartsWith("save"))
                SaveCommand();
            else if (command.StartsWith("load"))
                LoadCommand();
            else if (command.StartsWith("list"))
                ListCommand();
            else if (command == "help")
                HelpCommand();
            else if (command == "quit")
            {
                //Console.WriteLine("Application Exited. Press any key to close");
                Quit = true;
            }
            else
                Console.WriteLine("Error. {0} was not recognized, please try again.", command);
        }

        public static void HelpAddCommand()
        {
            // write Add commands to screen
            Console.WriteLine("Enter the type of diary entry:");
            Console.WriteLine(" 1 - General");
            Console.WriteLine(" 2 - Gratitude");
            Console.WriteLine(" 3 - Food");
            Console.WriteLine(" 4 - Fitness");
        }

        public static bool CheckTypeValid(string type)
        {
            // check the Type command value is valid
            bool result;

            try
            {
                // try converting to int value. if fails throw an error
                int i = int.Parse(type);

                // check value is in range
                if (i > 0 && i <= 4)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }

                return result;

            }
            catch (Exception)
            {
                // invalid command. return false value
                return false;
            }

        }


        public static void AddCommand()
        {
            bool isTypeValid = false;
            bool isEntryValid = false;
            int command = 1;

            string entry = "";

            DateTime today = DateTime.Now;

            // show commands. check command is valid
            while (!isTypeValid)
            {
                Console.WriteLine(string.Empty);
                HelpAddCommand();
                string line = Console.ReadLine();
                isTypeValid = CheckTypeValid(line);
                if (isTypeValid)
                {
                    command = int.Parse(line);
                }
                else
                    Console.WriteLine("Error. Command not valid.");

            }

            // the command was valid. now request entry value
            while (!isEntryValid)
            {
                Console.WriteLine(string.Empty);
                Console.WriteLine("Enter the diary text:");
                string line = Console.ReadLine();
                if (line.Length > 0)
                {
                    entry = line;
                    isEntryValid = true;
                }
                else
                    Console.WriteLine("Error. Please enter diary text.");
            }

            DiaryEntry diaryEntry = null;
            switch (command)
            {
                case 1:
                    diaryEntry = new GeneralEntry(today, entry);
                    break;
                case 2:
                    diaryEntry = new GratitudeEntry(today, entry);
                    break;
                case 3:
                    diaryEntry = new FoodEntry(today, entry);
                    break;
                case 4:
                    diaryEntry = new FitnessEntry(today, entry);
                    break;
                default:
                    break;
            }

            diary.AddEntry(diaryEntry);

            Console.WriteLine(string.Empty);
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine(string.Empty);
            Console.WriteLine("Success. Created entry: '{0}'", entry);
            Console.WriteLine(string.Empty);
            Console.WriteLine("---------------------------------------------------------------------------");

            Console.WriteLine(string.Empty);
            Console.WriteLine("Press any key to continue.");

            Console.ReadKey();

            //GradeBookUserInterface.CommandLoop(gradeBook);
        }

        public static void ListCommand()
        {

            string result = diary.GetAllEntries();

            Console.WriteLine(string.Empty);
            Console.WriteLine("The following is a list of entries:");
            Console.WriteLine("---------------------------------------------------------------------------");

            if (result.Length == 0)
                Console.WriteLine("No results. Please 'Add' entries to the diary");
            else
                Console.WriteLine(result);

            Console.WriteLine(string.Empty);
            Console.WriteLine("---------------------------------------------------------------------------");

            Console.WriteLine(string.Empty);
            Console.WriteLine("Press any key to continue.");

            Console.ReadKey();
        }


        public static void LoadCommand()
        {
            Console.WriteLine(string.Empty);
            Console.WriteLine("Diary entries loaded from xml file 'diary.xml':");
            Console.WriteLine("---------------------------------------------------------------------------");

            StringBuilder result = new StringBuilder();

            foreach (XElement level1Element in XElement.Load("diary.xml").Elements("entry"))
            {

                foreach (XElement level2Element in level1Element.Elements())
                {

                    string name = level2Element.Name.ToString().ToUpper();
                    string value = level2Element.Value;

                    if (name == "DATE")
                    {
                        result.AppendLine(string.Empty);
                    }

                    result.AppendLine(name + ": " + value);
                }
            }

            Console.WriteLine(result);

            Console.WriteLine(string.Empty);
            Console.WriteLine("---------------------------------------------------------------------------");

            Console.WriteLine(string.Empty);
            Console.WriteLine("Press any key to continue.");

            Console.ReadKey();


            //var gradeBook = BaseGradeBook.Load(name);

            // if (gradeBook == null)
            //return;

            //GradeBookUserInterface.CommandLoop(gradeBook);
        }

        public static void SaveCommand()
        {

            Console.WriteLine(string.Empty);

            Console.WriteLine("Diary entries saved to xml file 'diary.xml':");

            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine(string.Empty);

            string result = diary.SaveToXML();
            Console.WriteLine(result);

            Console.WriteLine(string.Empty);

            Console.WriteLine("---------------------------------------------------------------------------");

            Console.WriteLine(string.Empty);

            Console.WriteLine("Press any key to continue.");

            Console.ReadKey();

        }
        public static void HelpCommand()
        {
            string today = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            Console.WriteLine();
            Console.WriteLine("Diary accepts the following commands:");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Add - Creates a new Diary entry for " + today + ".");
            Console.WriteLine();
            Console.WriteLine("Save - Write all Diary entries to an xml file.");
            Console.WriteLine();
            Console.WriteLine("Load - Load all Diary entries from an xml file.");
            Console.WriteLine();
            Console.WriteLine("List - List all Diary entries.");
            Console.WriteLine();
            Console.WriteLine("Help - Displays all accepted commands.");
            Console.WriteLine();
            Console.WriteLine("Quit - Exits the application");
        }

    }
}
