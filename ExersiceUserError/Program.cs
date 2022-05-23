using ExersiceUserError;



internal class Program
{


    static void Main(string[] args)
    {
        List<UserError> userErrors = new List<UserError>();
        string input = "5";
      
        


        //Menyval
        do
        {
            ShowMenu(); //Menyval

            input = Console.ReadLine();
            Console.WriteLine(" "); //Läser in

            switch (input)
            {
                case "0": //Avsluta
                    Console.WriteLine("Tack och adjö");
                    Environment.Exit(0);
                    break;

                case "1": //testa om siffra
                    Console.WriteLine("Skriv in ditt test");
                    var x = Console.ReadLine();


                    if (x.All(char.IsDigit))
                    {
                        Console.WriteLine("Det är korrekt. Det är ett nummer.");

                    }
                    else
                    {
                        NumericInputError numericInputError = new NumericInputError();
                        userErrors.Add(numericInputError);
                        Console.WriteLine(numericInputError.UEMessage());
                    }
                    break;
                case "2": //testa om sträng

                    Console.WriteLine("Skriv in ditt test");
                    var y = Console.ReadLine();
                    if (y.All(char.IsLetter))
                    {
                        Console.WriteLine("Det är korrekt. Det är en sträng.");

                    }
                    else
                    {
                        TextInputError textInputError = new TextInputError();
                        userErrors.Add(textInputError);
                        Console.WriteLine(textInputError.UEMessage()); 

                    }
                    break;
                case "3": //Skirv ut Errors
                    foreach (var error in userErrors)
                    {
                        Console.WriteLine(error.UEMessage()); 
                    }
                    break;
                case "4":
                    Console.WriteLine("Skriv in ditt Användarnamn");
                    string username =  Console.ReadLine();

                    if (!String.IsNullOrEmpty(username))
                    {
                        Console.WriteLine("Test 1: inte null fungerar.");
                    }
                    else
                    {
                        NotEmpty notEmpty = new NotEmpty(); 
                        userErrors.Add(notEmpty);
                        Console.WriteLine(notEmpty.UEMessage());
                    }
                    if(!username.Contains(" "))
                    {
                        Console.WriteLine("Test 2: inga mellanslag fungerar.");
                    }
                    else
                    {
                        NoBlanks noBlanks = new NoBlanks();
                        userErrors.Add(noBlanks);
                        Console.WriteLine(noBlanks.UEMessage());
                    }
                    if(username.Length > 4)
                        Console.WriteLine("Test 3: längd fungerar. ");
                    else
                    {
                        RightLength rightLength = new RightLength();
                        userErrors.Add(rightLength);
                        Console.WriteLine(rightLength.UEMessage());
                    }
                    break;
                   
                default:

                    break;
            }

            } while (input != "0");
        void ShowMenu()
        {
            Console.WriteLine("*   0. Avsluta                    *");
            Console.WriteLine("*   1. Testa om det är en siffra  *");
            Console.WriteLine("*   2. Testa om det är ett ord    *");
            Console.WriteLine("*   3. Skriv ut errors            *");
            Console.WriteLine("*   4. Skriv in användarnamn. \n Minst 3 karaktärer, inga mellamslag  *");
        }
    }
}
