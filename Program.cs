//Shaun Aguirre-Reyes
// 10/18/22
// Resturant picker

Console.Clear();


string pickAgain = "YES";
while(pickAgain == "YES"){
    bool greatOptions = false;
    string category = "";
    Random random = new Random();
    string[] fastFood = {"McDonalds", "Wendys", "Burger King", "Taco bell", "Jack in the Box", "Taco Truck", "Chipotle", "In and Out", "Carls JR", "Chic Fil A"};
    string[] pizza = {"Pizza Hut", "Dominoes", "lil Ceasers", "Papa Johns", "Piology", "Micheals pizza", "Eddies Pizza", "Costco Pizza", "Frozen Pizza", "Chuck e Cheese"};
    string[] dineIn = {"Olive Garden", "Red Lobster", "Garlic Brothers", "Applebees", "Dennys", "IHOP", "The Habit", "Lumberjacks", "Black Bear Diner", "BJ's"};
    string[] all = {"Pizza Hut", "Dominoes", "lil Ceasers", "Papa Johns", "Piology", "Micheals pizza", "Eddies Pizza", "Costco Pizza", "Frozen Pizza", "Chuck e Cheese", 
                    "McDonalds", "Wendys", "Burger King", "Taco bell", "Jack in the Box", "Taco Truck", "Chipotle", "In and Out", "Carls JR", "Chic Fil A",
                    "Olive Garden", "Red Lobster", "Garlic Brothers", "Applebees", "Dennys", "IHOP", "The Habit", "Lumberjacks", "Black Bear Diner", "BJ's"};
    while (!greatOptions)
    {
    Console.WriteLine("Pick a category? 'fast food' 'pizza' 'dine in'");
    Console.WriteLine("Or type 'all' to generate from all categories.");
    category = Console.ReadLine().ToLower();
    switch(category)
    {
        case "fast food":
        greatOptions = true;
            int fastFoodIndex = random.Next(fastFood.Length);
            Console.WriteLine("");
            Console.WriteLine(fastFood[fastFoodIndex]);
        break;
        case "pizza":
        greatOptions = true;
            int pizzaIndex = random.Next(pizza.Length);
            Console.WriteLine("");
            Console.WriteLine(pizza[pizzaIndex]);
        break;
        case "dine in":
        greatOptions = true;
            int dineInIndex = random.Next(dineIn.Length);
            Console.WriteLine("");
            Console.WriteLine(dineIn[dineInIndex]);
        break;
        case "all":
        greatOptions = true;
            int allIndex = random.Next(all.Length);
            Console.WriteLine("");
            Console.WriteLine(all[allIndex]);
        break;

    }
    }
    Console.WriteLine("");
    Console.WriteLine("Do you want to try another option?? 'yes' 'no'");
    pickAgain = Console.ReadLine().ToUpper();
    if(pickAgain == "NO"){
        Console.WriteLine("Thank you for using our sevices :)");
    }else if (pickAgain != "YES" && pickAgain != "NO"){
        Console.WriteLine("I guess not. Have a good day :) ");
    }
}













