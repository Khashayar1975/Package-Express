using System; // Allows us to use Console methods such as WriteLine and ReadLine.

class Program // Defines the main Program class.
{
    static void Main(string[] args) // Main method where the program starts.
    {
        // Display the welcome message.
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Ask the user to enter the package weight.
        Console.WriteLine("Please enter the package weight:");
        decimal weight = Convert.ToDecimal(Console.ReadLine());

        // Check if the package is too heavy.
        if (weight > 50)
        {
            // Display an error message if the weight is greater than 50.
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");

            // End the program.
            return;
        }

        // Ask the user to enter the package width.
        Console.WriteLine("Please enter the package width:");
        decimal width = Convert.ToDecimal(Console.ReadLine());

        // Ask the user to enter the package height.
        Console.WriteLine("Please enter the package height:");
        decimal height = Convert.ToDecimal(Console.ReadLine());

        // Ask the user to enter the package length.
        Console.WriteLine("Please enter the package length:");
        decimal length = Convert.ToDecimal(Console.ReadLine());

        // Add all three dimensions together.
        decimal totalDimensions = width + height + length;

        // Check if the total dimensions are greater than 50.
        if (totalDimensions > 50)
        {
            // Display an error message if the package is too large.
            Console.WriteLine("Package too big to be shipped via Package Express.");

            // End the program.
            return;
        }

        // Calculate the shipping quote by multiplying the dimensions
        // by the weight and dividing the result by 100.
        decimal quote = (height * width * length * weight) / 100;

        // Display the shipping quote formatted as a dollar amount.
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));

        // Display the final thank-you message.
        Console.WriteLine("Thank you!");
    }
}
