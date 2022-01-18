
using Interactie;

Patrick pat = new Patrick();
Stefan st = new Stefan();
Bokito bok = new Bokito();
ACME acme = new ACME();

acme.Hire(st);
acme.Hire(pat);
acme.Hire(bok);

acme.StartProduction();
