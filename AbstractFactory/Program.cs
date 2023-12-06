// See https://aka.ms/new-console-template for more information

using AbstractFactory.Factories;
using AbstractFactory.Furnitures;
using AbstractFactory.Interfaces;

LuxuryFactory facto = new LuxuryFactory();


IChair chair = facto.CreateChair();

chair.SitOnIt();
