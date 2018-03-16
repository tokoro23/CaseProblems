// TK
// Date: 3/15/18
// Chapter 6 Case Problem 1
// Modified Ch6 case problem to include parallel arrays for names/talents

using static System.Console;
class GreenvilleRevenue
{
    static void Main()
    {
        WriteLine("Welcome to the...");
        WriteLine("**************");
        WriteLine("* GREENVILLE *");
        WriteLine("**************");
        WriteLine("Internal Revenue Estimator-Service");

        Write("\nPlease enter last year's number of contestants: ");
        int conNum1 = int.Parse(ReadLine());
        while (conNum1 < 0 || conNum1 > 30)
        {
            Write("Invalid entry, please enter integer 0-30 inclusive: ");
            conNum1 = int.Parse(ReadLine());
        }

        Write("Thank you! Now enter this year's number of contestants: ");
        int conNum2 = int.Parse(ReadLine());
        while (conNum2 < 0 || conNum2 > 30)
        {
            Write("Invalid entry, please enter integer 0-30 inclusive: ");
            conNum2 = int.Parse(ReadLine());
        }

        // S singing, D dancing, M musical instrument, O other
        string[] names = new string[conNum2];
        string[] talents = new string[conNum2];
        WriteLine("\n");
        for (int x = 0; x < conNum2; ++x)
        {
            Write("Enter contestant {0}'s name: ", x + 1);
            names[x] = ReadLine();
            Write("Enter their talent code: ");
            talents[x] = ReadLine().ToUpper();
            while (!(talents[x] == "S" || talents[x] == "D" ||
                  talents[x] == "M" || talents[x] == "O"))
            {
                Write("Invalid enry, S, D, M, or O: ");
                talents[x] = ReadLine().ToUpper();
            }
        }
        // counts
        int countS = 0;
        string namesS = "SINGING";
        int countD = 0;
        string namesD = "DANCING";
        int countM = 0;
        string namesM = "MUSIC";
        int countO = 0;
        string namesO = "OTHER";
        for (int x = 0; x < talents.GetLength(0); ++x)
        {
            if (talents[x] == "S")
            {
                ++countS;
                namesS += (", " + names[x]);
            }
            else if (talents[x] == "D")
            {
                ++countD;
                namesD += (", " + names[x]);
            }
            else if (talents[x] == "M")
            {
                ++countM;
                namesM += (", " + names[x]);
            }
            else
            {
                ++countO;
                namesO += (", " + names[x]);
            }
        }
        WriteLine("Displaying talent counts");
        WriteLine("Singing: {0}\nDancing: {1}" +
                  "\nMusic: {2}\nOther: {3}", countS, countD, countM, countO);
        const string END = "Q";
        string input = "";
        while (input != END)
        {
            WriteLine("Enter talent code for list of contestants, or Q to quit");
            input = ReadLine().ToUpper();
            if (input == "S")
                WriteLine(namesS);
            else if (input == "D")
                WriteLine(namesD);
            else if (input == "M")
                WriteLine(namesM);
            else if (input == "O")
                WriteLine(namesO);
            else if (input != "Q")
            {
                WriteLine("Invalid entry, enter talent code or Q to quit");
                input = ReadLine().ToUpper();
            }
        }
        WriteLine("Press any key to continue to revenue results");
        ReadKey();

        int lastRev = conNum1 * 25;
        int thisRev = conNum2 * 25;

        WriteLine("\nCalculating...Done!");
        WriteLine("\nWith an entrance fee of $25..." +
            "\nLast Year's revenue was: ${0}" +
            "\nand this year's revenue estimate is: ${1}", lastRev, thisRev);
        string compMes;
        if (conNum2 > (2 * conNum1))
            compMes = "Compared to last year, the competition is over twice as large!";
        else if (conNum2 > conNum1)
            compMes = "The competition is bigger than ever!";
        else if (conNum2 < conNum1)
            compMes = "A tighter race this year! Come out and cast your vote!";
        else
            compMes = "The competition is the same as last year.";
        WriteLine(compMes);

        WriteLine("\nThank you for using the Greenville " +
            "Internal Revenue Estimator-Service");
        WriteLine("And remember...");
        WriteLine("**********************************");
        WriteLine("* The stars shine in Greenville! *");
        WriteLine("**********************************");
    }
}