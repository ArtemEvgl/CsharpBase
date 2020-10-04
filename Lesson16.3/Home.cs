using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16._3
{
    class Home
    {
        string city;
        Street street;

        public Home(string city, Street street)
        {
            this.street = street;
            this.city = city;
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public Street Street
        {
            get { return street; }
            set { street = value; }
        }

        public Home Clone()
        {
            return this;
        }
        public Home DeepClone()
        {
            return new Home(this.city, (Street)this.street.Clone() as Street);
        }

        public override string ToString()
        {
            return $"{City} {Street}";
        }

    }

    class Street : ICloneable
    {

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Street(string name)
        {
            this.name = name;
        }

        public object Clone()
        {
            return new Street(this.name) as object;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
