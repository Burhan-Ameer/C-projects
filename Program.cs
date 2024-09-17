using System.Linq;
using System;
using System.Xml.Schema;
namespace linqdemo{
class Program{
    static void Main(string [] args){
        int [] age={1,2,45,3,2,211,55,33,2,8};// the data source could be of variaous types like collection in this case the collection is just an array
        //  the var data type is an implicit data types it means what ever data we give it to the linq it becomes datatype  of that variable

// var a= from x in age where x>20 select x;
// now if you want to order this in ascending or descending you can definately do that 
var a= from x in age where x>20 orderby x select x;// (well it is by default in ascending  order by  you can also write that )
// descennding order
// var a= from x in age where x>20  orderby x descending select x;
    foreach(int item in a){
        Console.WriteLine(item);
    }
    // Console.ReadLine();   
    }


}




}