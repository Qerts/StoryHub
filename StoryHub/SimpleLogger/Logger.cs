using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLogger
{
   public static class Logger
    {
        public static void CommonInput(string input)
        {
            commonLog(input);

        }

        private static string commonLog(string input)
        {
            string save = string.Empty;
            save = "Time: " + DateTime.Now + " " + "Subject: " + input;
            return save;
        }

        public static void Error_Input(string input) 
        {
            errorLog(input);
        
        }

        private static string errorLog(string input)
        {
            return ("!Error! " + "Time: " + DateTime.Now + " " + "Subject: " + input);
        }

        public static void Spec_Event(string input) 
        {
            spec_Event(input);
        }

        private static string spec_Event(string input)
        {
            return "Important: " + "Time: " + DateTime.Now + " " + "Subject " + input;

        }



        //je nutno implementovat tyto metody:
        //public void Input(string input) - metoda pro přijetí stringu 
        //private string foramtInput(string input) - metoda pro zformátování stringu
        //private void saveInput - metoda pro uložení stringu do logu, využije fileservice
        //private void startSending() - metoda, která začne odesílat v daném intervalu, k tomu použije timer, 
        //tato metoda také bude implementovat odesílání při uzavření programu a odesílání při průchodu bodem,
        //k čemuž může využít události, improvizovaně ale použijeme následující metodu
        //public void SendImmediate() - okamžité odeslání logu

        //je nutno implementovat tyto proměnné:
        //sender
        //fileservice

        
    }
}
