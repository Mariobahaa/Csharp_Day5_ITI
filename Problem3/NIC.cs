using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    class NIC
    {
        String Manufacture;
        int MACaddress;
        String Type;

        public static NIC NICcard
        {
            get;
        } = new NIC("IEEE", 111, "Ethernet");


        private NIC(String m, int ad , String t)
        {
            Manufacture = m;
            MACaddress = ad;
            Type = t;
        }

    }
}
