using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Grammatica_Beta
{
    class Parola
    {
        private const int MASCHILE = 0;
        private const int FEMMINILE = 1;
        private const int SINGOLARE = 0;
        private const int PLURALE = 1;
        private const int ARTICOLO = 0;
        private const int NOME = 1;
        private const int AGGETTIVO = 2;
        private const int PRONOME = 3;
        private const int VERBO = 4;
        private const int AVVERBIO = 5;
        private const int PREPOSIZIONE = 6;
        private const int CONGIUNZIONE = 7;
        private const int ESCLAMAZIONE = 8;
        private const int CULO = 9;
        private const int PRIMA = 1;
        private const int SECONDA = 2;
        private const int TERZA = 3;
        String parola;
        int genere;
        int pluralità;
        int parteDelDiscorso;
        bool verboRiflessivo;
        int persona;
    }
}
