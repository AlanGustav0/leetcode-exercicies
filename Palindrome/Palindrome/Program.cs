if (IsPalindrome(1110111))
{
    Console.WriteLine("It is a Palíndrome number");
}
else
{
    Console.WriteLine("It is not a Palíndrome number");
}

bool IsPalindrome(int value)
{
    var chars = value.ToString().Reverse().ToList();

    var comparableValue = "";

    chars.ForEach(value => comparableValue += value.ToString());

    if (value.ToString().Equals(comparableValue)) return true;

    return false;
}
