using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercure
{
    /// <summary>
    /// Sauvegarder des paramètres Global 
    /// </summary>
    public static class Global
    {
         
        private static string _ServiceUrl = "http://localhost:1438/Sources/Mercure.asmx";
       
        public static string ServiceUrl
        {
            set 
            { 
                _ServiceUrl = value;
            }

            get { return _ServiceUrl; }

        }

        
    }
}
