using System.Collections.Generic;

namespace Packt.Shared
{
    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            //Compare Name Lengths
            int result = x.Name.Length.CompareTo(y.Name.Length);

            //if they are equal
            if(result == 0){
                //then compare by the name
                return x.Name.CompareTo(y.Name);
            }else{
                //otherwise compare by lengths
                return result;
            }
        }
    }
}