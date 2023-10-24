
namespace Gegenstände
{
    using System.Collections.Generic; 
    using System.Linq;

    class Gegenstand
    {
        private int _höhe;
        public int Höhe {
            set => _höhe = value>0? _höhe = value:throw new Exception("negativer Wert");
            get => _höhe;
        }

        public Gegenstand(int h){
            Höhe = h;
        }

    }
}