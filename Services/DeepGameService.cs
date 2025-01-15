using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerediaJ_C_3_RPSLSProNEnd.Services
{
    public class DeepGameService
    {
        
        Random rng = new Random();

        public List<string> handPlay = new List<string>{
             "SCISSORS",
             "ROCK",
              "PAPER",
               "LIZARD",
                "SPOCK"
        };
        
      
        
        public string CPUChoice()
        {
             return handPlay[rng.Next(handPlay.Count)];
        }


    }
}