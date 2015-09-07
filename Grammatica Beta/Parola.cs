using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//http://digilander.libero.it/fabioutili/analgr.html

namespace Grammatica_Beta
{
    class Parola
    {
        //GENERE
        private const byte MASCHILE = 0;
        private const byte FEMMINILE = 1;
        //NUMERO
        private const byte SINGOLARE = 0;
        private const byte PLURALE = 1;
        //PARTE DEL DISCORSO
        private const byte ARTICOLO = 0;
        private const byte NOME = 1;
        private const byte AGGETTIVO = 2;
        private const byte PRONOME = 3;
        private const byte VERBO = 4;
        private const byte AVVERBIO = 5;
        private const byte PREPOSIZIONE = 6;
        private const byte CONGIUNZIONE = 7;
        private const byte ESCLAMAZIONE = 8;
        //CULO
        private const byte CULO = 9;
        //PERSONA
        private const byte PRIMA = 1;
        private const byte SECONDA = 2;
        private const byte TERZA = 3;
        //TIPO
        private const byte PERSONALE = 0;
        private const byte POSSESSIVO = 1;
        private const byte DIMOSTRATIVO = 2;
        private const byte INDEFINITO = 3;
        private const byte RELATIVO = 4;
        private const byte MISTO = 5;
        private const byte INTERROGATIVO = 6;
        private const byte ESCLAMATIVO = 7;
        private const byte PRONOME_PERSONALE = 8;
        private const byte DI_MODO = 9;
        private const byte DI_TEMPO = 10;
        private const byte DI_LUOGO = 11;
        private const byte DI_QUANTITà = 12;
        private const byte DI_AFFERMAZIONE = 13;
        private const byte DI_NEGOZIAZIONE = 14;
        private const byte DI_DUBBIO = 15;
        //DEGRADO
        private const byte POSITIVO = 0;
        private const byte COMPARATIVO_DI_UGUAGLIANZA = 1;
        private const byte COMPARATIVO_DI_MINORANZA = 2;
        private const byte COMPARATIVO_DI_MAGGIORANZA = 3;
        private const byte SUPERLATIVO_RELATIVO = 4;
        private const byte SUPERLATIVO_ASSOLUTO = 5;
        String parola;
        byte genere;
        byte numero;
        byte parteDelDiscorso;
        bool verboRiflessivo;
        byte persona;
        //personale (cfr. sotto), possessivo, dimostrativo, indefinito, relativo, misto, byteerrogativo o esclamativo4;
        byte tipo;
        //5) il grado (solo per l’aggettivo qualificativo): positivo, comparativo (di uguaglianza, minoranza o maggioranza), superlativo (relativo o assoluto)3.
        byte grado;
    }
}
