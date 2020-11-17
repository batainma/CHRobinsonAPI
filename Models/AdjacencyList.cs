using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CHRobinsonWebAPI.Models
{
    // Hard-coded entries of North American countries into an adjacency list
    public class AdjacencyList
    {
        protected static List<List<int>> adjLi;

        public AdjacencyList()
        {
            /*
             * USA - 0
             * CAN - 1
             * MEX - 2
             * BLZ - 3
             * GTM - 4
             * SLV - 5
             * HND - 6
             * NIC - 7
             * CRI - 8
             * PAN - 9
             */
            adjLi = new List<List<int>>();

            adjLi.Add(new List<int> { 1, 2 });
            adjLi.Add(new List<int> { 0 });
            adjLi.Add(new List<int> { 0, 3, 4 });
            adjLi.Add(new List<int> { 2, 4 });
            adjLi.Add(new List<int> { 2, 3, 5, 6 });
            adjLi.Add(new List<int> { 4, 6 });
            adjLi.Add(new List<int> { 4, 5, 7 });
            adjLi.Add(new List<int> { 6, 8 });
            adjLi.Add(new List<int> { 7, 9 });
            adjLi.Add(new List<int> { 8 });

        }

        // Getter for adjLi
        public List<List<int>> get()
        {
            return adjLi;
        }


        // Generate a dictionary of countries to ints
        public Dictionary<string, int> createHash()
        {
            Dictionary<string, int> hash = new Dictionary<string, int>();

            hash["USA"] = 0;
            hash["CAN"] = 1;
            hash["MEX"] = 2;
            hash["BLZ"] = 3;
            hash["GTM"] = 4;
            hash["SLV"] = 5;
            hash["HND"] = 6;
            hash["NIC"] = 7;
            hash["CRI"] = 8;
            hash["PAN"] = 9;

            return hash;
        }

        // Generate a dictionary of ints to countries
        public Dictionary<int, string> createInverseHash()
        {
            Dictionary<int, string> hash = new Dictionary<int, string>();

            hash[0] = "USA";
            hash[1] = "CAN";
            hash[2] = "MEX";
            hash[3] = "BLZ";
            hash[4] = "GTM";
            hash[5] = "SLV";
            hash[6] = "HND";
            hash[7] = "NIC";
            hash[8] = "CRI";
            hash[9] = "PAN";

            return hash;
        }

    }
}
