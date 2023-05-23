using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAdministrationApi
{
    //The method instantiate an object generically.
    /*The where T : class, K, new() constraint is applied to the T type parameter. 
     * This constraint ensures that T must be a reference type (class), 
     * implement or derive from the K base type, and have a default parameterless constructor (new()).
    */
    public static class FactoryPattern<K,T> where T : class,K,new()
    {
        public static K GetInstance()
        {
            K objK;
            objK = new T();
            return objK;

        }
    }
}
