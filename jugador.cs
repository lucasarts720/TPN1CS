using System;
using System.Collections.Generic;
using Jugadores;
using clase2;

namespace Jugadores
{
  public class Jugador {
    public string Name { get; set; }
    public int Edad { get; set; }

    public bool Activo { get; set; }
    public List <Arma> Armas { get; set; }
    public List<Shield> listaEscudos { get; set; }
    public Jugador(string Name, int Edad, List<Arma> Armas, List<Shield> listaEscudos, bool Activo = false) {
      this.Name = Name;
      this.Edad = Edad;
      this.Activo = Activo;
      this.Armas = Armas;
      this.listaEscudos = listaEscudos;
    }

    public string IsActivo() { 
      return this.Activo ? "Jugador Activo" : "Jugador necesita activar su cuenta";
    }

    public void readshields() {
            int escudoCount = 0;
            int escudoAmount = 0;
          Console.WriteLine("<Estado de Escudos>");

        for (int i1 = 0; i1 < listaEscudos.Count; i1++)
        {
          escudoCount = i1;
        }
        foreach (Shield i2 in listaEscudos)
        {
          escudoAmount = i2.CantEscudo;
          Console.WriteLine(escudoAmount + " " + i2.NombreEscudo);
        }
    }
  }
    public class Arma {
        public string Name { get; set; }
        public int Balas { get; set; }

        public Arma (string Name, int Balas) {
// para referirse a los "name" y "bala" de los PUBLIC STRING y PUBLIC INT
// de afuera de Public Arma hay que usar "this.name" y "this.bala"
            this.Name = Name;
            this.Balas = Balas;
        } 
    
    }

    public class Shield {
      public string NombreEscudo { get; set; }
      public int CantEscudo { get; set; }

      public Shield (string NombreEscudo, int CantEscudo) {
        this.NombreEscudo = NombreEscudo;
        this.CantEscudo = CantEscudo;
      }
    }
}