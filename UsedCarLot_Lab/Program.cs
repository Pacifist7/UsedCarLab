using UsedCarLot_Lab;



CarLot carlot1 = new CarLot();



while (true)
{
    Console.WriteLine("Welcome to Speedy Gonzales car dealership! What would you like to do? \n 1. Purchase a car \n 2. Sell us your car \n 3. Exit");



    var answer1 = Console.ReadLine();

    if (answer1 == "1")
    {
        carlot1.ListCars();
        Console.WriteLine("Please pick the make of the car that you would like to purchase");
        var make = Console.ReadLine();

        carlot1.RemoveCars(make);
        carlot1.ListCars();

        Console.WriteLine("Would you like to continue? y/n");
        var answer2 = Console.ReadLine();

        if (answer2 == "y")
        {
            continue;
        }
        else
        {
            Console.WriteLine("All right, thank you, have a great day!");
            break;
        }
    }

    else if (answer1 == "2")
    {
        Console.WriteLine("What's your car make");
        var make = Console.ReadLine();

        Console.WriteLine("What's your car model");
        var model = Console.ReadLine();

        Console.WriteLine("What's your car year");
        var year = int.Parse(Console.ReadLine());

        Console.WriteLine("What's your car price");
        var price = int.Parse(Console.ReadLine());

        Console.WriteLine("What's your car mileage");
        var mileage = int.Parse(Console.ReadLine());

        var car1 = (new UsedCar(make, model, year, price, mileage));

        carlot1.AddCars(car1);

        carlot1.ListCars();

        Console.WriteLine("Would you like to continue? y/n");
        var answer3 = Console.ReadLine();

        if (answer3 == "y")
        {
            continue;
        }
        else
        {
            Console.WriteLine("All right, thank you and have a great day!");
            break;
        }
    }
    else
    {
        Console.WriteLine("All right, thank you, have a great day!");
        break;
    }
}



