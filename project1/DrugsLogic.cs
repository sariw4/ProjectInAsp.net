using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace project1
{
    public class DrugsLogic
    {
        public string GetDrugsResults(string[] drugsNDCs)
        {
            DrugAnalysis dal = new DrugAnalysis();
            return dal.GetDrugsResult(drugsNDCs);
        }
    }
}
