using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLogger
{
   public static class Logger
    {
       private static string foramtInput(string input) 
       {
           string save = string.Empty;
           save=input
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
