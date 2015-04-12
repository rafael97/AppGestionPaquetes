using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using App.Modelo;

namespace App.Datos
{
    public class BillsRepositories
    {

            static List<Bills> data = new List<Bills>();
           static List<Package> dataP = new List<Package>();

            static Person send = new Person();
            static Person recib = new Person();

            static  Dictionary<Package, double> packages1 = new Dictionary<Package, double>();



            public void borrarList()
            {
                dataP.Clear();
            }

            public void AddPaquete(Package p)
            {
                dataP.Add(p);


            }

            public void facturar()
            {
                Bills b1 = new Bills(new DateTime(),packages1);

                data.Add(b1);

            }



        public IEnumerable<Bills> getBills()
        {
            //getPackges();
             return data;
        }
        
        public IEnumerable<Package> getPackges()
        {
            /* List<Package> data = new List<Package>();

            Package pg1 = new Package("T123", send, recib, 46.5, 5000.0);
            Package pg2 = new Package("T124", recib, send, 26.5, 4000.0);
            Package pg3 = new Package("T125", send, recib, 16.5, 3000.0);

            data.Add(pg1);
            data.Add(pg2);
            data.Add(pg3);
       
            foreach (Bills item in data)
            {
                if ()
                {
                    
                }
            }
               */
            return dataP;
        }



    }

}