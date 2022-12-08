using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTrackingSystem
{
    class Connection
    {
        public class Utils
        {
            private static string Connection = "datasource=lochnagar.abertay.ac.uk;database=sql2204315;username=sql2204315;password=45Hysx3CEDI4";
            //https://stackoverflow.com/questions/20500680/how-to-make-a-connection-string-class
            //link above helped with making connection string class.
            public static string ConnectionString
            {
                get
                {
                    return Connection;
                }
                set
                {
                    Connection = value;
                }
            }
        }
    }
}
