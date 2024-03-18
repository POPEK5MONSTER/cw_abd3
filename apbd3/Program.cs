// See https://aka.ms/new-console-template for more information

using apbd3.Ships;
using cw2.Containers;


LiquidContainer liquidContainer1 = new LiquidContainer(0,3, 100, 6, 2000, PossibleProducts.Fuel , true);
GasConteiner gasConteiner = new GasConteiner(0,3, 100, 6, 2000, PossibleProducts.Oxygen , 0.22);
LiquidContainer liquidContainer2 = new LiquidContainer(0,5, 100, 4, 1000, PossibleProducts.Gasoline , true);

liquidContainer1.Load(200.00);
Ship ship1 = new Ship(100,100,100000);
Ship ship2 = new Ship(100, 100, 1000);
ship1.LoadContainer(liquidContainer1);
ship1.LoadContainer(liquidContainer2);
ship1.LoadContainer(gasConteiner);
ship1.UnloadContainers(gasConteiner);
gasConteiner.Unload();
ship1.ChangeContainerWithNumber(liquidContainer1, liquidContainer2);
ship1.changeContainer(ship2, liquidContainer1);
ship1.InfoShip();
liquidContainer2.InfoContainer();
