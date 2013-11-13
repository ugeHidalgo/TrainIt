using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainItLibrary
{
    public class Global
    {
        public static string userNameWorking = "No User";
        public static Int64 userIDWorking = -1;

        public static Training trainingUsed = new Training();
        public static Material materialUsed = new Material();
        public static SportTypes sportTypeUsed = new SportTypes();
        public static Users userUsed = new Users();

        public static Exception noCreated = new Exception("NO implementado");
    }
}
