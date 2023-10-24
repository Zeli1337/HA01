
namespace Fächer
{
    
    using System.Collections.Generic; 
    using System.Linq;
    using Gegenstände;
    class Fach
    {
        private int _höhe;
        public int Höhe {
            set => _höhe = value>0? _höhe = value:throw new Exception("negativer Wert");
            get => _höhe;
        }
        private Gegenstand _gegenstand;
        public Gegenstand Gegenstand{
            set =>  _gegenstand = value.Höhe<=Höhe? value: throw new Exception("Der Gegenstand ist zu groß");
            get => _gegenstand;
        } 

        public Fach(int h, Gegenstand g){
            Höhe = h;
            if(g == null){
                throw new Exception("Gegenstand nicht vorhanden");
            }
            Gegenstand = g;
        }

        public override string ToString()
        {
            return $"Fachhöhe {Höhe} - Gegenstand Höhe {Gegenstand.Höhe}";
             
        }

    }

}
    