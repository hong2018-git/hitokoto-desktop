﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Hitokoto
{
    class HitokotoMethods
    {
        public static string  Get()
        {
            string result = "";
            var hitokotoResponse =  HttpWebResponseUtility.CreateGetHttpResponse("https://v1.hitokoto.cn/", 5000, "HitokotoDesktop/1.0", "", null);
            Stream resStream = hitokotoResponse.Content.ReadAsStream();
            using (StreamReader sr = new(resStream))
            {
                result = sr.ReadToEnd();
            }
            return result;
        }
    }
}
