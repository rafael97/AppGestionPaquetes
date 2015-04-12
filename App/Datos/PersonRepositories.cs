using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using App.Modelo;

namespace App.Datos
{
    public class PersonRepositories
    {
        static List<Person> data = new List<Person>();

        public void AddPerson(Person p)
        {
            data.Add(p);

        }

        public IEnumerable<Person> getPersonas()
        {
            return data;

        }

        

        public bool consultar(long codigo)
        {
            bool variable = false;
            foreach (Person item in data)
            {
                if (item.Id==codigo)
                {
                    variable = true;  
                }
            }

            return variable;
        }

      
    }
}