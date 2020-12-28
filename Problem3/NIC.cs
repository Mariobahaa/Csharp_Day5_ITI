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

        String pManufacuture
        {

            get { return Manufacture; }
            set { Manufacture = value; }
        }

        int pMACaddress
        {

            get { return MACaddress; }
            set { MACaddress = value; }
        }
        String pType
        {

            get { return Type; }
            set { Type = value; }
        }


    }
}
