using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLogger
{
    public static class Settings
    {
        private static string path = "D:/";
        public static string Path
        {
            set;
            get;
        }

        private static double interval;
        public static double Interval
        {
            set;
            get;
        }

        private static string email = "pepa.verovsky@seznam.cz";
        public static string Email
        {
            set;
            get;
        }

        private static bool send = false;
        public static bool Send
        {
            set;
            get;
        }


        private static bool save = false;
        public static bool Save
        {
            set;
            get;
        }

        private static bool send_when_error = false;
        public static bool Send_When_Error
        {
            set;
            get;
        }

        private static bool send_when_off = false;
        public static bool Send_When_Off
        {
            set;
            get;
        }

        private static bool send_when_spec_point = false;
        public static bool Send_When_Spec_Point
        {
            set;
            get;
        }
        //je nutné vytvořit properties pro:
        //cestu - cesta pro uložení souboru
        //interval - časová perioda, ve které je log ukládán
        //e-mail - adresa, na kterou bude log odesílán
        //odesílání - příznak určující, zda je log odesílán
        //ukládání - příznak určující, zda je log lokálně uchováván, v opačném případě je mazán v případě příliš velké velikosti složky
        //odeslání při pádu
        //odeslání pri ukončení programu
        //odeslání při průchodu specifickým bodem
    }

    
}
