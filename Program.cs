using System;
using System.Collections.Generic;
using Jugadores;

namespace clase2
{
    class Program
    {
        static void Main(string[] args)
        { 
            Arma arma1 = new Arma ("arma1", 100);
            Arma arma2 = new Arma ("arma2", 100);
            Arma arma3 = new Arma ("arma3", 100);

            List <Arma> Armas = new List<Arma>() {arma1, arma2};

            Armas.Add(arma3);

            Shield Energia = new Shield ("Escudo de Energia", 300);
            Shield Fisico = new Shield ("Escudo Fisico", 150);
            Shield Elemental = new Shield ("Escudo Elemental", 100);
            Shield Termico = new Shield ("Escudo Termico", 200);

            List<Shield> Escudos = new List<Shield>() {Energia, Fisico, Elemental, Termico};

            Jugador jug1 = new Jugador("Pepe", 30, Armas, Escudos, true);
            Jugador jug2 = new Jugador("Pepe1", 20, Armas, Escudos);
            Jugador jug3 = new Jugador("Pepe2", 30, Armas, Escudos, true);

            jug1.readshields();

        }
    }
}