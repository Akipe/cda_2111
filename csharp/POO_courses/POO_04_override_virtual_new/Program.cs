// See https://aka.ms/new-console-template for more information

using POO_04_override_virtual_new;
using POO_04_override_virtual_new.animal;

Zoo myZoo = new Zoo();
Lion myLion = new Lion();
Elephant myElephant = new Elephant();

List<Animal> allAnimals = new List<Animal>();
allAnimals.Add(myElephant);
allAnimals.Add(myLion);

myZoo.Animals = allAnimals;

myZoo.WashAllAnimals();
myZoo.GiveEatAllAnimals();
