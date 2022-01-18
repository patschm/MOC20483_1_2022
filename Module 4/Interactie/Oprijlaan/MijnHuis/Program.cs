using DoomsdayPreppers;
using Heras;
using Infrac;
using Philips;

Lamp tl = new Lamp();
Hek hek = new Hek();
Valkuil kuil = new Valkuil();

Detectielus lus = new Detectielus();

lus.Detect += tl.Aan;
lus.Detect += hek.Open;
lus.Detect += kuil.Open;

lus.OnDetect();
