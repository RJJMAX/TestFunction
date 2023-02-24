using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFunction; 
public class NewFunction {
    public static int AFunction(int x) { 
        if(x < -10 || x >= 5) {
            throw new Exception("X is outside domain!");
        }
        return x + 1;
    }

}
