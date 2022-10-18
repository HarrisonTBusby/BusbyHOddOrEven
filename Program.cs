//Harrison Busby
//10/18/2022
//Mini Challenge 6
//Odd or Even

string numbOne;
bool isNumber = true;
int validNumber = 0;
string playAgain = "yes";



while(playAgain == "yes"){

Console.WriteLine("Give me a number");
numbOne = Console.ReadLine();

isNumber = Int32.TryParse(numbOne, out validNumber);

if(!isNumber){
    Console.WriteLine("Please give me a valid number.");
}else{
   
if(validNumber % 2 == 0){
    Console.WriteLine(numbOne + " is even number");
}else{
    Console.WriteLine(numbOne + " is an odd number");
}

Console.WriteLine("Would you like to play again? Type 'yes' if yes.");
    playAgain = Console.ReadLine().ToLower();
    if(playAgain == "yes"){
        Console.WriteLine("Lets play again.");
    }else{
        Console.WriteLine("Go away.");
    }
    }
}
