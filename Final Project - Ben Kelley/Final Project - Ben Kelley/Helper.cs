using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace Final_Project___Ben_Kelley
{
    public abstract class Helper
    {
        /// <summary>
        /// Helper parent class that starts the connection string and HttpClient
        /// </summary>
        string cs { get; set; }
        static readonly HttpClient client = new HttpClient();
    }
}
