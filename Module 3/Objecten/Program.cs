// Big bang

using Objecten;

//Lamp l1 = new Lamp();
//l1.color = ConsoleColor.Yellow;
//l1.lumen = 400;
//l1.SetLumen(300);
// l1.Color = ConsoleColor.Red;
// l1.Lumen = 500;

// l1.Aan();

// Generalisatie
Lamp t2 = new TL { Color = ConsoleColor.Blue, Lumen = 200, StartTime = 2};
//(t2 as TL)!.StartTime = 6;
t2.Aan();


DoeIets(new TL { Color = ConsoleColor.Red});

void DoeIets(Lamp lmp)
{
    lmp.Aan();
}

// Big cruch
