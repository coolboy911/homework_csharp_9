// Пользователь вводит скобочные последовательности. 
// В последовательности могут встретиться скобки вида: {}, (), [].

// Правильная скобочная последовательность - символьная последовательность, 
// составленная в алфавите, состоящем из символов, сгруппированных в упорядоченные пары.

// Пример правильной скобочной последовательности: (), ()[]{}
// Пример неправильной: (], ({)}
// Написать программу, которая определяет правильная ли скобочная последовательность была введена

bool IsBracketsCorrect(string text)
{
    Stack<char> bracket = new Stack<char>();
    foreach (char symbol in text)
    {
        if (symbol == '(' || symbol == '[' || symbol == '{') bracket.Push(symbol);

        if (symbol == ')')
        {
            if (bracket.Peek() == '(') bracket.Pop();
            else return false;
        }
        if (symbol == ']')
        {
            if (bracket.Peek() == '[') bracket.Pop();
            else return false;
        }
        if (symbol == '}')
        {
            if (bracket.Peek() == '{') bracket.Pop();
            else return false;
        }
    }
    if (bracket.Count == 0) return true;
    else return false;
}

Console.Clear();
string rightBrackets = "(), ()[]{}";
string wrongBrackets = "(], ({)}";

Console.WriteLine(IsBracketsCorrect(rightBrackets));
Console.WriteLine(IsBracketsCorrect(wrongBrackets));
