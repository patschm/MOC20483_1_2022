using Radio;

RadioStation r538 = new RadioStation();

r538.subscribers += OntvangstMethodes.ViaEther;
r538.subscribers += OntvangstMethodes.ViaMail;
r538.subscribers += OntvangstMethodes.ViaTamtam;
r538.subscribers += OntvangstMethodes.ViaKabel;
r538.subscribers += OntvangstMethodes.ViaEther;
r538.subscribers += OntvangstMethodes.ViaMail;
r538.subscribers += OntvangstMethodes.ViaTamtam;
r538.subscribers += OntvangstMethodes.ViaKabel;
r538.subscribers += OntvangstMethodes.ViaEther;
r538.subscribers += OntvangstMethodes.ViaMail;
r538.subscribers += OntvangstMethodes.ViaTamtam;
r538.subscribers += OntvangstMethodes.ViaKabel;
r538.subscribers += OntvangstMethodes.ViaEther;
r538.subscribers += OntvangstMethodes.ViaMail;
r538.subscribers += OntvangstMethodes.ViaTamtam;
r538.subscribers += OntvangstMethodes.ViaKabel;
r538.subscribers += OntvangstMethodes.ViaEther;
r538.subscribers += OntvangstMethodes.ViaMail;
r538.subscribers += OntvangstMethodes.ViaTamtam;
r538.subscribers += OntvangstMethodes.ViaKabel;

//r538.subscribers.Invoke("Heya!!");

r538.Broadcast();