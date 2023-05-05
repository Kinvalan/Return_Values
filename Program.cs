


/*
Oppgave 1:
Lag en metode som tar inn og returnerer summen av to tall


Oppgave 2:
Lag en metode skal printe setningen "Denne metoden returnerer ingenting" til konsollen.
Denne metoden skal altså ikke returnere noe verdi ;)  
*/


namespace Return_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv inn det første tallet:");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv inn det andre tallet:");
            int number2 = int.Parse(Console.ReadLine());

            int sum = ReturnSumOfNums(number1, number2);

            Console.WriteLine("Summen av " + number1 + " og " + number2 + " er " + sum);

            PrintButDontReturn();
        }

        
        static int ReturnSumOfNums(int number1, int number2)  // Oppg 1
        {
            int sum = number1 + number2;
            return sum;
        }

        static void PrintButDontReturn()   // Oppg 2
        {
            Console.WriteLine("Denne metoden (PrintButDontReturn) returnerer ingenting");
        }

    }
}














