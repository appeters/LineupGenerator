using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToExcel;
using LinqToExcel.Query;
using Softball.Team;

namespace LineupGenerator.DataProviders
{
    public class ExcelDataReader : IDataProvider
    {
        private string _filePath;
        public ExcelDataReader(string filePath)
        {
            _filePath = filePath;
        }

        public List<Player> GetPlayers()
        {
            using (var excel = new ExcelQueryFactory(_filePath))
            {
                excel.StrictMapping = StrictMappingType.Both;
                excel.UsePersistentConnection = true;


                var allPlayers = from c in excel.Worksheet<Player>()
                                   select c;

               return allPlayers.ToList();
            }
        }


    }
}
