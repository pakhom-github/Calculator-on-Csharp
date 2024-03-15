while(true)
    {

    Console.Write(" Введите первое число: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите второе число:  ");
    int b = Convert.ToInt32(Console.ReadLine());

    Console.Write("Что будем делать? +, -, /, *  ");
    char action = Convert.ToChar(Console.ReadLine());

    switch (action)
    {
        case '+':
            int Resultplus = a + b;
            Console.Write("Результат: " + Resultplus);
            break;

        case '-':
            int Resultminus = a - b;
            Console.Write("Результат: " + Resultminus );
            break;

        case '*':
            int ResultMult = a * b;
            Console.Write("Результат: " + ResultMult);
            break;
    
        case '/':
        int ResultFis = a / b;
         Console.Write("Результат: " + ResultFis);
            break;
    }
} 