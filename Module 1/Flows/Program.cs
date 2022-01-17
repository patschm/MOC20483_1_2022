var number = 4;
int counter = 1;

// Als je niet weet hoe vaak herhaalt moet worden, maar tenminste een keer uitgevoerd.
do
{
    System.Console.WriteLine(counter++);
}
while(counter < 10);

// Als je niet weet hoe vaak herhaalt moet worden, maar 0 of meer keer uitgevoerd.
while(counter < 10)
{
    System.Console.WriteLine(counter++);
}

// Gebruik je alleen als je weet hoe vaak iets uitgevoerd moet worden.
for(counter = 1; counter < 10; counter++)
{
    if (counter == 5) continue;
    System.Console.WriteLine(counter);
}


switch(number)
{
    case 1:
        System.Console.WriteLine("Een");
        break;
    case 2:
        System.Console.WriteLine("Twee");
        break;
    default:
        System.Console.WriteLine("Anders");
        break;
}

if (number > 5)
{
    System.Console.WriteLine("Not done");
}
else
{
    System.Console.WriteLine("Wel doen");
}








