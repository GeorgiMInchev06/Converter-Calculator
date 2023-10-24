while (true)
{
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1. Binary to Decimal");
    Console.WriteLine("2. Decimal to Binary");
    Console.WriteLine("3. Decimal to Hexadecimal");
    Console.WriteLine("4. Hexadecimal to Decimal");
    Console.WriteLine("5. Decimal to Octal");
    Console.WriteLine("6. Octal to Decimal");
    Console.WriteLine("7. Exit");
    Console.WriteLine();

    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.Write("Enter a binary number: ");
            string binaryInput = Console.ReadLine();
            int decimalResult = BinaryToDecimal(binaryInput);

            Console.WriteLine($"Decimal: {decimalResult}");
            Console.WriteLine();
            break;

        case 2:
            Console.Write("Enter a decimal number: ");
            int decimalInput = int.Parse(Console.ReadLine());
            string binaryResult = DecimalToBinary(decimalInput);

            Console.WriteLine($"Binary: {binaryResult}");
            Console.WriteLine();
            break;

        case 3:
            Console.Write("Enter a decimal number: ");
            int decimalInputForHexadecimal = int.Parse(Console.ReadLine());
            string hexadecimalResult = DecimalToHexadecimal(decimalInputForHexadecimal);

            Console.WriteLine($"Hexadecimal: {hexadecimalResult}");
            Console.WriteLine();
            break;

        case 4:
            Console.Write("Enter a hexadecimal number: ");
            string hexadecimalInput = Console.ReadLine();
            int decimalResultFromHex = HexadecimalToDecimal(hexadecimalInput);

            Console.WriteLine($"Decimal: {decimalResultFromHex}");
            Console.WriteLine();
            break;

        case 5:
            Console.Write("Enter a decimal number: ");
            int decimalInputForOctal = int.Parse(Console.ReadLine());
            string octallResult = DecimalToOctal(decimalInputForOctal);

            Console.WriteLine($"Octal: {octallResult}");
            Console.WriteLine();
            break;

        case 6:
            Console.Write("Enter a octal number: ");
            string octalInput = Console.ReadLine();
            int decimalResultFromOctal = OctalToDecimal(octalInput);

            Console.WriteLine($"Decimal: {decimalResultFromOctal}");
            Console.WriteLine();
            break;


        case 7:
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Invalid option. Choose again.");
            Console.WriteLine();
            break;
    }

}
static int BinaryToDecimal(string binaryNumber)
{
    return Convert.ToInt32(binaryNumber, 2);
}

static string DecimalToBinary(int decimalNumber)
{
    return Convert.ToString(decimalNumber, 2).ToUpper();
}
static string DecimalToHexadecimal(int decimalNumber)
{
    return Convert.ToString(decimalNumber, 16).ToUpper();
}

static int HexadecimalToDecimal(string hexadecimalNumber)
{
    return Convert.ToInt32(hexadecimalNumber, 16);
}

static string DecimalToOctal(int decimalNumber)
{
    return Convert.ToString(decimalNumber, 8).ToUpper();
}
static int OctalToDecimal(string octalNumber)
{
    return Convert.ToInt32(octalNumber, 8);
}