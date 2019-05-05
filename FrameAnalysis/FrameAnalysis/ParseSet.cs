using System;
using Newtonsoft.Json;

namespace FrameAnalysis
{
    public class ParseSet
    {
        private enum ID{
            NONE = 0,
            AT = 1,
            CELL = 2,
            MOTOR = 3,
        }
        static public string Parse(Byte[] data)
        {
            try
            {
                Param param = new Param();
                param.Param1 = "";
                param.Param2 = "";
                param.Param3 = "";
                param.Param4 = "";

                var id = data[4];
                switch ((ID)id)
                {
                    case 0:

                        break;
                    case ID.AT:
                        if(data[7] == 3)
                        {
                            param.Param1 = "123";
                            param.Param2 = "123";
                            param.Param3 = "123";
                        }
                        break;
                    case ID.CELL:
                        break;
                    case ID.MOTOR:
                        break;
                    default:
                        break;
                    
                }
                return JsonConvert.SerializeObject(param);
                
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

    internal class Param
    {
        public string Param1 { get; set; }
        public string Param2 { get; set; }
        public string Param3 { get; set; }
        public string Param4 { get; set; }
    }
}
