namespace topic_5_part_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int correct, planets;
            double total;
            string planetMoon, trueOrFalse, explosion;
            total = 4;
            correct = 0;

            // question one

            Console.WriteLine("Quiz time! Let's test your skill!");
            Console.WriteLine("QUESTION ONE");
            Console.WriteLine();
            Console.Write("How many planets are in the solar system? ");
            Int32.TryParse(Console.ReadLine(), out planets);

            if (planets == 8)
            {
                Console.WriteLine("Correct!");
                correct +=1;
            }
            else
            {
                Console.WriteLine("Incorrect! There are 8 planets in the solar system.");
            }
            Console.WriteLine("Press ENTER to Continue");
            Console.ReadLine();
            Console.Clear();

            // question two

            Console.WriteLine("QUESTION TWO");
            Console.WriteLine();
            Console.WriteLine("Which of the following planets do NOT have a moon?");
            Console.WriteLine();
            Console.WriteLine("A. Saturn");
            Console.WriteLine("B. Mars");
            Console.WriteLine("C. Venus");
            Console.WriteLine("D. Neptune");
            Console.Write("Select: ");
            planetMoon = Console.ReadLine().ToUpper();

            if (planetMoon == "A")
                Console.WriteLine("Incorrect! Saturn infact has 146 moons!");
            else if (planetMoon == "B")
                Console.WriteLine("Incorrect! Mars has two moons! Phobos and Deimos!");
            else if (planetMoon == "C")
            {
                Console.WriteLine("Correct! Venus has no moons!");
                correct += 1;
            }
            else if (planetMoon == "D")
                Console.WriteLine("Incorrect! Neptune has 16 moons!");
            else
                Console.WriteLine("That's not a valid answer! Try again.");
            Console.WriteLine("Press ENTER to Continue");
            Console.ReadLine();
            Console.Clear();

            // question three
            Console.WriteLine("QUESTION THREE");
            Console.Write("When a massive star blows up, what is the explosion called? ");
            explosion = Console.ReadLine().ToLower();
            if (explosion == "supernova" || explosion == "supernovae")
            {
                Console.WriteLine("Correct! Unfortunately, our star is too small for a supernova to occur.");
                correct += 1;
            }
            else
            {
                Console.WriteLine("Incorrect! Massive stars explode into what is called 'supernova'.");
            }
            Console.WriteLine("Press ENTER to Continue");
            Console.ReadLine();
            Console.Clear();

            // question four

            Console.WriteLine("QUESTION FOUR");
            Console.WriteLine();
            Console.WriteLine("True or False:");
            Console.Write("Spaghettification is the process of what happens when you fall into a black hole? ");
            trueOrFalse = Console.ReadLine().ToLower();
            if (trueOrFalse == "true")
            {
                Console.WriteLine("Correct!");
                correct += 1;
            }
            else
                Console.WriteLine("Incorrect. It's true.");
            Console.WriteLine("Press ENTER to Continue");
            Console.ReadLine();
            Console.Clear();

            // totaling up the answers

            Console.WriteLine("You got " + correct + " answers right");
            Console.WriteLine("This is a score of " + ((correct / total) * 100) + " percent.");
        }
    }
}
