Double numberOfSandwiches;
Double numberOfToppings;
Double tip;
Double COST_OF_SANDWICH = 4.75;     //Initialize all of the variable and values we will use
Double COST_OF_TOPPING = 0.55;
Double totalSandwichCost;
Double totalToppingCost;
Double baseCost;
Double orderCost;


Console.WriteLine("Enter the amount of sandwiches you would like.");    //Ask user input on sandwiches
numberOfSandwiches = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the total amount of toppings across all sandwiches."); //Ask user input on toppings
numberOfToppings = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your tip in USD");                             //Ask user input on tip
tip = Convert.ToInt32(Console.ReadLine());

totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches;              //These are unnecessary if you want to shorten the amount of lines used
totalToppingCost = COST_OF_TOPPING * numberOfToppings;                  //All these do are calculate price of Sandwiches and then Toppings

baseCost = totalSandwichCost + totalToppingCost;                        //Add previous two prices
orderCost = tip + baseCost*(1-.10);                                     //Add tip and basecost with discount

Console.WriteLine("Your total is $"+orderCost);                         //output total


/* This can be shortened by initializing within the lines in
which variables are introduced. Also, this process is unnecesasarily
long. baseCost can be removed as a Processing item if ALL orders are
discounted on a given day, and Discount can be a user input,
or it can be defined day-by-day and applied to every order and added
to the orderCost function */