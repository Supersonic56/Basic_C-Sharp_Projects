﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_drill
{
    //define a void method called Quit()
    interface IQuittable
    {
        void Quit();
    }
}

/*
Perform these actions and create a console app that includes the following:
Create an interface called IQuittable and have it define a void method called Quit().
Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose.
Use polymorphism to create an object of type IQuittable and call the Quit() method on it. Hint: an object can be of an interface type if it implements that specific interface.

 */
