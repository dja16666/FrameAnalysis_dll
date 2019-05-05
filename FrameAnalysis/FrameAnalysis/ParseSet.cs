using System;
using Newtonsoft.Json;

namespace FrameAnalysis
{
    public class ParseSet
    {
        static public string Parse(Byte[] data)
        {
            try
            {
                Param param = new Param();
                param.Param1 = "";
                param.Param2 = "";
                param.Param3 = "";

                var id = data[4];
                switch (id)
                {
                    case 0:

                        break;
                    case 1:
                        if(data[7] == 3)
                        {
                            param.Param1 = "123";
                            param.Param2 = "123";
                            param.Param3 = "123";
                        }
                        break;
                    case 2:
                        break;
                    case 3:
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
    }
}
