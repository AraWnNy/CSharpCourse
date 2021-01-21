using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    class InternalModifier
    {
        Demo3 demo = new Demo3();
        //Demo3 class'ının bildirgeçi internal olduğu için erişim sağlanabildi.
        Demo3.NotPrivateInnerClass notPrivate = new Demo3.NotPrivateInnerClass();
    }
}
