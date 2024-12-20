using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    // what can read and wite the namespace
    // 1- class
    // 2- struct( stands for structure)
    // 3- interface 
    // 4- Eum
    //----------------------------------------------------------------------------------
    // Allowed Access modifiers inside namespace
    // 1- internal(Defualt)
    // 2- Public 
    public class TypeA
    {
        private int x;
        internal int y;
        public int z;



        #region  Definitions


        // What you can write Inside the class or struct
        // 1- Attribute (Filled variable)
        // 2- property( Full property - automatic property - Indexer)
        // 3- Functions (Constructor - Getter/Setter - Method)
        // 4- Events
        //---------------
        //Allowed Access modifier inside the struct 
        //    1- private  متشاف في حدود الستراكت بس 
        //    2- internal متشاف في حدود المشروع 
        //    3- public مهزق ابن مهزق


        //Allowed Access modifier inside Class
        // 1- Private
        // 2- Private Protected
        // 3- Protected
        // 4- Internal 
        // 5- Internal Protected
        // 6- public
        // ----------------

        // what you can write inside the interface
        // 1- Signature for property
        // 2- Signature for Method
        // 3- Default implemented Metho d

        // default access modifier inside interface is public

        #endregion


    }
}
