﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{

    public class Computer
    {
        public string IP { get; set; }
        public List<int> OpenPorts { get; set; }

        public Computer()
        {
            OpenPorts = new List<int>();
        }
    }

    /*
    public class Computers
    {
        //public string name;
        public string ip { get; set; }


        public Computers()
        {
            //name = "unknown";
            ip = "unknown";
        }
        public void SetIP(string newIP)
        {
            ip = newIP;
        }


        /*public virtual string ToPrintableString()
        {
            return string.Join(", ",
                this.GetType()
                .GetFields()
                .Select(p => p.Name + ": " + p.GetValue(this));
        }*/
    
    //public List<Computer> computers = new List

}
